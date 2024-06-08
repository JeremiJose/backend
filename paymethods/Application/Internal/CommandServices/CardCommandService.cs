using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Commands;
using Paymethods.paymethods.Domain.Repositories;
using Paymethods.paymethods.Domain.Services;
using Paymethods.Shared.Domain.Repositories;

namespace Paymethods.paymethods.Application.Internal.CommandServices
{
    public class CardCommandService(ICardRepository cardRepository, IUnitOfWork unitOfWork):
        ICardCommandService
    {
        public async Task<Card?> Handle(CreateCardCommand command)
        {
            var card = new Card(command);
            try
            {
                await cardRepository.AddAsync(card);
                await unitOfWork.CompleteAsync();
            }
            catch (Exception e)
            {
                return null;
            }

            return card;
        }
    }
}