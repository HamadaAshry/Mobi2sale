using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.AdminPanel.Web.Subcategories;

namespace Domain.AdminPanel.Web.Items {
    public class Item {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public Decimal SupplyPrice { get; set; }

        public Decimal RetailPrice { get; set; }

        public Decimal WholesalePrice { get; set; }

        public string Color { get; set; }   

        public string Code { get; set; }

        public int Quantity { get; set; }       

        public int SafeLimit { get; set; }  

        public string MainImageUrl { get; set; }

        public string CoverImageUrl { get; set; }   

        public string CreatedBy { get; set; }

        public DateTime CraetedAt { get; set; }

        public bool IsDeleted { get; set; }

        public string ModifiedBy { get; set; }
        
        public DateTime ModifiedAt { get; set; }

        public Guid SubcategoryId { get; set; }

        public SubCategory Subcategory { get; set; }



    }
}