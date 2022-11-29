using System.Threading.Tasks;
using WorldCupTeamsGraphQL.DTOS;

namespace WorldCupTeamsGraphQL.Services
{
    public interface IWorldCupService
    {
        TeamDTO[] FindTeamBy(string Name);
        TeamDTO[] FindAll();
        TeamDTO FindTeamBy(int key);
    }
}
