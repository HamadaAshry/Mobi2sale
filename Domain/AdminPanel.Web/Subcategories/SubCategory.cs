using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.AdminPanel.Web.Categories;
using Domain.AdminPanel.Web.Items;

namespace Domain.AdminPanel.Web.Subcategories
{
    public class SubCategory
    {
        public SubCategory()
        {
            Items=new HashSet<Item>();
        }
        [Column("pk_Subcategories_Id")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CraetedAt { get; set; }

        public bool IsDeleted { get; set; }

        public string ModifiedBy { get; set; }
        
        public DateTime ModifiedAt { get; set; }

        [Column("fk_Categories_subCategories_CategoryId")]
       public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}