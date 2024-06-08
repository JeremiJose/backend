using Paymethods.paymethods.Domain.Model.Commands;
using Paymethods.paymethods.Interfaces.REST.Resources;

namespace Paymethods.paymethods.Interfaces.REST.Transform;

public static class CreateWalletCommandFromResourceAssembler
{
    public static CreateWalletCommand ToCommandFromResource(CreateWalletResource resource) => 
        new(resource.QuantityCard, resource.UserId);
}