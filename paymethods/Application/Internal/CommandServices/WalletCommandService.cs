using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Commands;
using Paymethods.paymethods.Domain.Repositories;
using Paymethods.paymethods.Domain.Services;
using Paymethods.Shared.Domain.Repositories;

namespace Paymethods.paymethods.Application.Internal.CommandServices;

public class WalletCommandService(IWalletRepository walletRepository, IUnitOfWork unitOfWork) : 
    IWalletCommandService
{
    public async Task<Wallet?> Handle(CreateWalletCommand command)
    {
        var wallet = new Wallet(command);
        try
        {
            await walletRepository.AddAsync(wallet);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return wallet;
    }
}