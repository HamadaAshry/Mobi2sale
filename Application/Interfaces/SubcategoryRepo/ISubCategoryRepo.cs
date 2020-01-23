using System;
using System.Collections.Generic;
using Application.Interfaces.Persistence;
using Domain.AdminPanel.Web.Subcategories;
using System.Threading.Tasks;
using Application.Envelopes;

namespace Application.Interfaces.SubcategoryRepo
{
    public interface ISubCategoryRepo:IGenericRepository<SubCategory>
    {
        Task<Envelopes<SubCategory>> FindSubCategoriesBycategoryId(IPaginationAndFilterProps props,Guid catId);
    }
}