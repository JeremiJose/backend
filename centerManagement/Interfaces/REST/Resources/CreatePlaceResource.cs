namespace CenterManagement.centerManagement.Interfaces.REST.Resources;

public record CreatePlaceResource(string Name,string Address, int Capacity, int Ruc);