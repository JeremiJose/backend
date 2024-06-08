using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Queries;
using Paymethods.paymethods.Domain.Repositories;
using Paymethods.paymethods.Domain.Services;

namespace Paymethods.paymethods.Application.Internal.QueriesServices
{
    public class CardQueryService(ICardRepository cardRepository) : ICardQueryService
    {
        public async Task<IEnumerable<Card>> Handle(GetAllCardQuery query)
        {
            return await cardRepository.FindAllAsync();
        }

        public async Task<Card?> Handle(GetCardByIdQuery query)
        {
            return await cardRepository.FindByIdAsync(query.Id);
        }

        public async Task<IEnumerable<Card>> Handle(GetCardByWalletIdQuery query)
        {
            return await cardRepository.FindByWalletIdAsync(query.IdWallet);
        }
    }
}

    