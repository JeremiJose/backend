using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Commands;

namespace Paymethods.paymethods.Domain.Services;

public interface IWalletCommandService
{
    Task<Wallet?> Handle(CreateWalletCommand command);
}