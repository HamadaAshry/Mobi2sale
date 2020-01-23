using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Interfaces.Persistence;
using Domain.AdminPanel.Web.Categories;

namespace Application.Interfaces.CategoryRepositories
{
    public interface ICategoryRepo:IGenericRepository<Category>
    {
    
    }
}