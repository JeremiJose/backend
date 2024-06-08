using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Interfaces.REST.Resources;

namespace Paymethods.paymethods.Interfaces.REST.Transform;

public class WalletResourceFromEntityAssembler
{
    public static WalletResource ToResourceFromEntity(Wallet entity) =>
        new WalletResource(entity.Id, entity.QuantityCard, entity.CreationDate, entity.UserId);
}