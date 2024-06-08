using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Repositories;
using Backend_MyEventec.Shared.Infraestructure.Persistence.EFC.Configuration;
using Backend_MyEventec.Shared.Infraestructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend_MyEventec.EventAndTicketing.Infraestructure.Persistence.EFC.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Event>> FindByAllEventAsync()
        {
            return await Context.Set<Event>().ToListAsync();
        }

        public async Task<Event?> FindByEventIdAsync(int id) 
        {
            return await Context.Set<Event>().FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<Event>> FindByHeadquartersAsync(int headquartersId)
        {
            return await Context.Set<Event>().Where(f => f.IdHeadquarters == headquartersId).ToListAsync();
        }

        public async Task<IEnumerable<Event>> FindByOrganizerIdAsync(int organizerId)
        {
            return await Context.Set<Event>().Where(f => f.IdOrganizer == organizerId).ToListAsync();
        }
    }
}