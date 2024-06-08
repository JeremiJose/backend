namespace Backend_MyEventec.EventAndTicketing.Interfaces.REST.Resources;

public record EventResource(int Id, int IdHeadquarters, int IdOrganizer, string Name,DateTime StartDate, DateTime FinishDate,string Description,int TotalTicket,string Status );