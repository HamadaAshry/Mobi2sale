using System;

namespace Application.Admin.web.SubCategories.Dtos {
    public class CreateSubCategoryReponseDto {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }

    }
}