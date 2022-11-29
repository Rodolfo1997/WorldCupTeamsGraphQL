using HotChocolate.Types;
using WorldCupTeamsGraphQL.DTOS;

namespace WorldCupTeamsGraphQL.GraphQL.Types
{
    public class PlayersTypes : ObjectType<PlayerDTO>
    {
        protected override void Configure(IObjectTypeDescriptor<PlayerDTO> player)
        {
            player.Field(t => t.Key).Type<IntType>();
            player.Field(t => t.Name).Type<StringType>().Description("Player Name example");
            player.Field(t => t.Team).Type<StringType>().Description("Team Name example");
            player.Field(t => t.Age).Type<IntType>().Description("Player Age example");
        }
    }
}
