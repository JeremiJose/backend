namespace Paymethods.paymethods.Domain.Model.Commands
{
    public record CreateCardCommand(string Number, string DueDate, string CssCode);
}