using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Envelopes;
using Application.Interfaces;
using Application.Interfaces.SubcategoryRepo;
using Domain.AdminPanel.Web.Subcategories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Admin.Web.Repos {
    public class SubCategoryRepo : GenericRepository<SubCategory>, ISubCategoryRepo {
        private readonly DataContext _context;
        public SubCategoryRepo (DataContext context) : base (context) {
            _context = context;

        }

        public async Task<Envelopes<SubCategory>> FindSubCategoriesBycategoryId (IPaginationAndFilterProps props, Guid catId) {

            if((props.PageSize == null && !props.PageSize.HasValue)||props.PageSize.Value==0 ) props.PageSize=10;
            if((props.PageNumber == null && !props.PageNumber.HasValue)||props.PageNumber.Value==0 ) props.PageNumber=1;
          
            var subcategories = _context.Subcategories.
            Where(sc => !sc.IsDeleted && sc.CategoryId == catId);

            if (!string.IsNullOrEmpty (props.SearchText) && !string.IsNullOrWhiteSpace (props.SearchText)) {
               
                    subcategories=  subcategories.
                    Where (sc => sc.Name.Contains (props.SearchText));                                    
                };     
                              
                return new Envelopes<SubCategory> {
                Data = await subcategories.
                OrderBy (sc => sc.Name). 
                Skip (props.PageSize.Value * (props.PageNumber.Value - 1)).
                Take (props.PageSize.Value).
                ToListAsync () ,
                RecordsCount = subcategories.Count (),
                };
            

        }
    }
}