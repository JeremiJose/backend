namespace CenterManagement.centerManagement.Domain.Model.Commands;

public record CreatePlaceCommand(string Name, string Address, int Capacity, int Ruc );