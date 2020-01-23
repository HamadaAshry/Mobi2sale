using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Infrastructure
{
    public interface IFileHandler
    {
         Task<String> SaveFile (IFormFile file, string folder);
         bool DeleteFile (string path, string folder);
         void ValiadteFile (IFormFile file);
         void ValiadteMainFile (IFormFile file);

    }
}