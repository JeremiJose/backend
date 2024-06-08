using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Queries;
using Paymethods.paymethods.Domain.Repositories;
using Paymethods.paymethods.Domain.Services;

namespace Paymethods.paymethods.Application.Internal.QueriesServices;

public class WalletQueryService(IWalletRepository walletRepository) : IWalletQueryService
{
    public async Task<IEnumerable<Wallet>> Handle(GetAllWalletsQuery query)
    {
        return await walletRepository.FindAllAsync();
    }

    public async Task<Wallet?> Handle(GetWalletByIdQuery query)
    {
        return await walletRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Wallet>> Handle(GetWalletsByUserIdQuery query)
    {
        return await walletRepository.FindByUserIdAsync(query.UserId);
    }
}