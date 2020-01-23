using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Infrastructure {
    public class FileHandler : IFileHandler {
        private readonly IHostingEnvironment _env;
        public FileHandler (IHostingEnvironment env) {
            this._env = env;
        }

        public async Task<String> SaveFile (IFormFile file, string folder) {

            var fileName = $"{Guid.NewGuid().ToString()}.{file.FileName.Split('.')[1]}";
            var directory = Path.Combine (_env.WebRootPath, "images", folder);
            if (!Directory.Exists (directory)) { Directory.CreateDirectory (directory); }
            var path = Path.Combine (_env.WebRootPath, "Images", folder, fileName);

            using (var fileStream = new FileStream (path, FileMode.Create)) {
                await file.CopyToAsync (fileStream);
                return $"images/{folder}/{fileName}";
            }

        }

        public bool DeleteFile (string path, string folder) {
            var files = Directory.GetFiles ($"{_env.WebRootPath}\\images\\{folder}", path.Split ('/')[2], SearchOption.AllDirectories);
            if (files.Length > 0) {
                foreach (var file in files) {
                    
                        var fileInfo = new System.IO.FileInfo (file);
                        fileInfo.Delete ();                

                }
                return true;
            } 
            else return false;

        }
        public void ValiadteFile (IFormFile file) {
            if (file.Length > (50 * 1024))
                throw new Exception ("Cover image size is larger than 50 kbs!");
            if (file.ContentType != "image/png" && file.ContentType != "image/jpg" && file.ContentType != "image/jpeg")
                throw new Exception ("Image Type must be only jpeg or png!");
        }

        public void ValiadteMainFile(IFormFile file)
        {
             if (file.Length > (100 * 1024))
                throw new Exception ("Main image size is larger than 100 kbs!");
            if (file.ContentType != "image/png" && file.ContentType != "image/jpg" && file.ContentType != "image/jpeg")
                throw new Exception ("Image Type must be only jpeg or png!");
        }
    }
}