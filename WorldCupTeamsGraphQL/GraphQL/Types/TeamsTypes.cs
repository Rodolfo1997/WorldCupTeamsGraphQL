using HotChocolate.Types;
using System.Collections.Generic;
using WorldCupTeamsGraphQL.DTOS;

namespace WorldCupTeamsGraphQL.GraphQL.Types
{
    public class TeamsTypes: ObjectType<TeamDTO>
    {
        protected override void Configure(IObjectTypeDescriptor<TeamDTO> team)
        {
            team.Field(t => t.Key).Type<IntType>();
            team.Field(t => t.Name).Type<StringType>().Description("team name example");
            team.Field(t => t.Shield).Type<StringType>().Description("shield url example");
            team.Field(t => t.Titles).Type<IntType>().Description("Number of Titles example");
            team.Field(t => t.BestPlayer).Type<PlayersTypes>().Description("BestPlayer example");
            team.Field(t => t.Players).Type<ListType<PlayersTypes>>().Description("Players example");
        }
    }
}
