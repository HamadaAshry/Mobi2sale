using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.AdminPanel.Web.Subcategories;



namespace Domain.AdminPanel.Web.Categories {
    public class Category {
        public Category()
        {
            Subcategories=new HashSet<SubCategory>();
        }
        [Column("pk_Categories_Id")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CraetedAt { get; set; }

        public bool IsDeleted { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedAt { get; set; }

     public ICollection<SubCategory> Subcategories { get; set; }

    }
}