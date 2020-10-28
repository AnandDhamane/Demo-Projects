using GraphQLDemoAPI.Infrastructure.DBContext;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQLDemoAPI.Repositories {
    public interface ITechEventRepository {
        Task<TechEventInfo[]> GetTechEvents();
        Task<TechEventInfo> GetTechEventById(int id);
        Task<List<Participant>> GetParticipantInfoByEventId(int id);
    }
}