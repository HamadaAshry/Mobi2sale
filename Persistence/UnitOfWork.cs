using System;
using System.Threading.Tasks;
using Application.Interfaces.CategoryRepositories;
using Application.Interfaces.Items;
using Application.Interfaces.OfferRepo;
using Application.Interfaces.Persistence;
using Application.Interfaces.SubcategoryRepo;
using Persistence.Admin.Web.Repos;

namespace Persistence {
    public class UnitOfWork : IUnitOfWork {
        private readonly DataContext _context;
       public ICategoryRepo CatRepo { get ; }

        public ISubCategoryRepo SupCatRepo { get ; }

        public IitemRepo ItemRepo { get ; }

        public IOfferRepo offerRepo { get ; }

        public UnitOfWork (DataContext context) {
            _context = context;
            CatRepo=new CategoryRepo(_context);  
            SupCatRepo=new SubCategoryRepo(_context);
            ItemRepo=new ItemRepo(_context);
            offerRepo=new OfferRepo(_context);
        }
        public async Task<int> SaveAsync () {
            return await _context.SaveChangesAsync ();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls


        protected virtual void Dispose (bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    this._context.Dispose ();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose () {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose (true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        
        #endregion

    }
}