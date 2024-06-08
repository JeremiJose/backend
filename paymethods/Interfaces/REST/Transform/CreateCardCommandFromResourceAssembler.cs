using Paymethods.paymethods.Domain.Model.Commands;
using Paymethods.paymethods.Interfaces.REST.Resources;

namespace Paymethods.paymethods.Interfaces.REST.Transform;

public static class CreateCardCommandFromResourceAssembler
{
    public static CreateCardCommand ToCommandFromResource(CreateCardResource resource) => 
        new(resource.Number, resource.DueDate, resource.CssCode);
}