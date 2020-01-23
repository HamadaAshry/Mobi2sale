using Application.Admin.web.Categories;
using Application.Admin.web.Categories.Commands;
using Application.Admin.web.Categories.Dtos;
using Application.Admin.web.Categories.Queries;
using Application.Admin.web.Items.Command;
using Application.Admin.web.Items.Dtos;
using Application.Admin.web.Items.Quries;
using Application.Admin.web.SubCategories;
using Application.Admin.web.SubCategories.Commands;
using Application.Admin.web.SubCategories.Dtos;
using Application.Admin.web.SubCategories.Queries;
using AutoMapper;
using Domain.AdminPanel.Web.Categories;
using Domain.AdminPanel.Web.Items;
using Domain.AdminPanel.Web.Subcategories;

namespace AutoMapperProfiles {
    public class ApplicationProfile : Profile {
        public ApplicationProfile () {
            //Categories
            CreateMap<Category, List.Query> ();
            CreateMap<Category, Details.Query> ();
            CreateMap<Category, Create.Command> ();
            CreateMap<Category, Create.Command> ().ReverseMap ();
            CreateMap<Category, Edit.Command> ();
            CreateMap<Category, Edit.Command> ().ReverseMap ();
            CreateMap<Category, CreateReponseDto> ();
            CreateMap<Category, EditCategoryResponseDto> ().ReverseMap ();
            CreateMap<Category, EditCategoryResponseDto> ();
            CreateMap<Category, CreateReponseDto> ().ReverseMap ();
            CreateMap<Category, ListResponseDto> ();
            CreateMap<Category, ListResponseDto> ().ReverseMap ();

            //subcategories
            CreateMap<SubCategory, SubCatList.Query> ();
            CreateMap<SubCategory, SubCatDetails.Query> ();
            CreateMap<SubCategory, CreateSubcategory.Command> ();
            CreateMap<SubCategory, CreateSubcategory.Command> ().ReverseMap ();
            CreateMap<SubCategory, EditSubCategory.Command> ();
            CreateMap<SubCategory, EditSubCategory.Command> ().ReverseMap ();
            CreateMap<SubCategory, CreateSubCategoryReponseDto> ();
            CreateMap<SubCategory, EditSubcatResponseDto> ().ReverseMap ();
            CreateMap<SubCategory, CreateSubCategoryReponseDto> ().ReverseMap ();
            CreateMap<SubCategory, EditSubcatResponseDto> ();
            CreateMap<SubCategory, ListSubcategoryResponseDto> ();
            CreateMap<SubCategory, ListSubcategoryResponseDto> ().ReverseMap ();

            //items          
            CreateMap<Item, CreateItem.Command>();
            CreateMap<Item, CreateItem.Command>().ReverseMap();
            CreateMap<Item, EditItem.Command>();
            CreateMap<Item, EditItem.Command>().ReverseMap();
            CreateMap<Item, ItemResponseDto> ();
            CreateMap<Item, ItemResponseDto> ().ReverseMap ();
            CreateMap<Item, ItemsResponseDto> ();
            CreateMap<Item, ItemsResponseDto> ().ReverseMap ();

        }
    }
}