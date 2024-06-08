using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Commands;

namespace CenterManagement.centerManagement.Domain.Services;

public interface IPlaceCommandService
{
    Task<Place?> Handle(CreatePlaceCommand command);
}