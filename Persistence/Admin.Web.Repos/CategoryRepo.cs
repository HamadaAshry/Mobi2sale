using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Interfaces.CategoryRepositories;
using Domain.AdminPanel.Web.Categories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Admin.Web.Repos
{
    public class CategoryRepo : GenericRepository<Category>, ICategoryRepo
    {
        private readonly DataContext _context;
        public CategoryRepo(DataContext context) : base(context)
        {
            _context = context;

        }

      
    }
}