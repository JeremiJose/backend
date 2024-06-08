using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Queries;

namespace Paymethods.paymethods.Domain.Services
{
    public interface ICardQueryService
    {
        Task<IEnumerable<Card>> Handle(GetAllCardQuery query);
        Task<Card?> Handle(GetCardByIdQuery query);
        Task<IEnumerable<Card>> Handle(GetCardByWalletIdQuery query);
    }
}