using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Commands;

namespace Paymethods.paymethods.Domain.Services
{
    public interface ICardCommandService
    {
        Task<Card?> Handle(CreateCardCommand command);
    }
}