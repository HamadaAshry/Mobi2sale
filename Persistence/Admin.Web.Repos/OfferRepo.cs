using System.Threading.Tasks;
using Application.Envelopes;
using Application.Interfaces;
using Application.Interfaces.OfferRepo;
using Domain.AdminPanel.Web.Offers;

namespace Persistence.Admin.Web.Repos
{
    public class OfferRepo : GenericRepository<Offer>, IOfferRepo
    {
        public OfferRepo(DataContext context) : base(context)
        {
        }

        public Task<Envelopes<Offer>> FindItemsBySubcategoryId(IPaginationAndFilterProps props)
        {
            throw new System.NotImplementedException();
        }
    }
}