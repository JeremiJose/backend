using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Model.Queries;

namespace Paymethods.paymethods.Domain.Services;

public interface IWalletQueryService
{
    Task<IEnumerable<Wallet>> Handle(GetAllWalletsQuery query);
    Task<Wallet?> Handle(GetWalletByIdQuery query);
    Task<IEnumerable<Wallet>> Handle(GetWalletsByUserIdQuery query);
}