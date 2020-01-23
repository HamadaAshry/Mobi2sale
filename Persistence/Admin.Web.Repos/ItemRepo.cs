using System;
using System.Linq;
using System.Threading.Tasks;
using Application.Envelopes;
using Application.Interfaces;
using Application.Interfaces.Items;
using Domain.AdminPanel.Web.Items;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Admin.Web.Repos {
    public class ItemRepo : GenericRepository<Item>, IitemRepo {
        private readonly DataContext _context;
        public ItemRepo (DataContext context) : base (context) {
            this._context = context;

        }

        public async Task<Envelopes<Item>> FindItemsBySubcategoryId (IPaginationAndFilterProps props, Guid subcatId) {
             if((props.PageSize == null && !props.PageSize.HasValue)||props.PageSize.Value==0 ) props.PageSize=10;
            if((props.PageNumber == null && !props.PageNumber.HasValue)||props.PageNumber.Value==0 ) props.PageNumber=1;
          
            var items = _context.Items.
            Where(item => !item.IsDeleted && item.SubcategoryId == subcatId);

            if (!string.IsNullOrEmpty (props.SearchText) && !string.IsNullOrWhiteSpace (props.SearchText)) {
               
                    items=  items.
                    Where (item => item.Name.Contains (props.SearchText)||
                    item.Code.Contains(props.SearchText)||
                    item.Color.Contains(props.SearchText)||
                    (!string.IsNullOrEmpty(item.Description)&& item.Description.Contains(props.SearchText)) 
                     );                                    
                };     
                              
                return new Envelopes<Item> {
                Data = await items.
                OrderBy (sc => sc.Name). 
                Skip (props.PageSize.Value * (props.PageNumber.Value - 1)).
                Take (props.PageSize.Value).
                ToListAsync () ,
                RecordsCount = items.Count (),
                };
            
        }
    }
}