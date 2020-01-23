using System;

namespace Application.Admin.web.Items.Dtos
{
    public class ItemResponseDto
    {
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

        public Guid SubcategoryId { get; set; }

    }
}