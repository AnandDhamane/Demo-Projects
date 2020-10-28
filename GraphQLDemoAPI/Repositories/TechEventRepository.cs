using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLDemoAPI.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemoAPI.Repositories {
    /// <summary>  
    /// TechEventRepository.  
    /// </summary>  
    public class TechEventRepository : ITechEventRepository {

        /// <summary>  
        /// The _context.  
        /// </summary>  
        private readonly GraphQLDemoContext _context;

        public TechEventRepository(GraphQLDemoContext context) {
            this._context = context;
        }

        public async Task<List<Participant>> GetParticipantInfoByEventId(int id) {
            return await (from ep in this._context.EventParticipants
                          join p in this._context.Participant on ep.ParticipantId equals p.ParticipantId
                          where ep.EventId == id
                          select p).ToListAsync();
        }

        public async Task<TechEventInfo> GetTechEventById(int id) {
            return await Task.FromResult(_context.TechEventInfo.FirstOrDefault(i => i.EventId == id));
        }

        public async Task<TechEventInfo[]> GetTechEvents() {
            return _context.TechEventInfo.ToArray();
        }
    }
}