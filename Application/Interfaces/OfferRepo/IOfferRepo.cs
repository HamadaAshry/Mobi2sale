using System.Threading.Tasks;
using Application.Envelopes;
using Application.Interfaces.Persistence;
using Domain.AdminPanel.Web.Offers;

namespace Application.Interfaces.OfferRepo {
    public interface IOfferRepo : IGenericRepository<Offer> {
        Task<Envelopes<Offer>> FindItemsBySubcategoryId (IPaginationAndFilterProps props);

    }
}