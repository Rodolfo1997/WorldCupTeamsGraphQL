using WorldCupTeamsGraphQL.DTOS;
using WorldCupTeamsGraphQL.Service;

namespace WorldCupTeamsGraphQL.GraphQL
{
    public class Query
    {
        public TeamDTO FindTeamBy(int key) => new WorldCupService().FindTeamBy(key);
        public TeamDTO[] FindTeamByName(string name) => new WorldCupService().FindTeamBy(name);
    }
}
