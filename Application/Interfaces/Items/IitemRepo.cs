using System;
using System.Threading.Tasks;
using Application.Envelopes;
using Application.Interfaces.Persistence;
using Domain.AdminPanel.Web.Items;

namespace Application.Interfaces.Items {
    public interface IitemRepo:IGenericRepository<Item> 
    {   
        Task<Envelopes<Item>> FindItemsBySubcategoryId (IPaginationAndFilterProps props, Guid catId);

    }
}