using System;

namespace Application.Admin.web.Categories.Dtos {
    public class CreateReponseDto {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}