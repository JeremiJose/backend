namespace Backend_MyEventec.EventAndTicketing.Interfaces.REST.Resources;

public record TicketResource(int Id, int EventId, int ClientId,int Price,string Category );