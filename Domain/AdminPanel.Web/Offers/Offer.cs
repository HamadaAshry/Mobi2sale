using System;

namespace Domain.AdminPanel.Web.Offers {
    public class Offer {
        public Guid Id { get; set; }

        public Guid ItemId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal OfferPrice { get; set; }

        public string ImageUrl { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CraetedAt { get; set; }

        public bool IsDeleted { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedAt { get; set; }
    }
}