using UserManagement.userManagement.Domain.Model.Commands;

namespace UserManagement.userManagement.Domain.Model.Aggregates;

public class Client
{
    public int Id { get; private set; }
    public int UserId { get; private set; }

    protected Client()
    {
        this.UserId = 0;
    }

    public Client(CreateClientCommand command)
    {
        this.UserId = command.UserId;
    }
}