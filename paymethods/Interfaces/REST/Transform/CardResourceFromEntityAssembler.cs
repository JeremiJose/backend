using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Interfaces.REST.Resources;

namespace Paymethods.paymethods.Interfaces.REST.Transform;

public class CardResourceFromEntityAssembler
{
    public static CardResource ToResourceFromEntity(Card entity) =>
        new CardResource(entity.Id, entity.IdWallet, entity.Number, entity.DueDate, entity.CssCode);
}