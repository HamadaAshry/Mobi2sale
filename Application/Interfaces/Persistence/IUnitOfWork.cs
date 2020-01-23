using System;
using System.Threading.Tasks;
using Application.Interfaces.CategoryRepositories;
using Application.Interfaces.Items;
using Application.Interfaces.OfferRepo;
using Application.Interfaces.SubcategoryRepo;
using Domain.AdminPanel.Web.Categories;

namespace Application.Interfaces.Persistence {
    public interface IUnitOfWork : IDisposable {
        ICategoryRepo CatRepo { get; }
        ISubCategoryRepo SupCatRepo { get; }
        IitemRepo ItemRepo { get; }
        IOfferRepo offerRepo {get;}

        Task<int> SaveAsync ();
    }
}