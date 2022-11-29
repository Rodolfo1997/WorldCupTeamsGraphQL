using System.Collections.Generic;
using System.Linq;
using WorldCupTeamsGraphQL.Domains;
using WorldCupTeamsGraphQL.DTOS;
using WorldCupTeamsGraphQL.Services;

namespace WorldCupTeamsGraphQL.Service
{
    public class WorldCupService : IWorldCupService
    {
        private readonly List<Team> defaultTeams;
        public WorldCupService()
        {
            this.defaultTeams = TeamsMock.CreatDefaultTeams();
        }

        public TeamDTO[] FindTeamBy(string name)
        {
            var teams = defaultTeams.Where(x => x.Name.ToUpper() == name.ToUpper());

            if (teams == null || !teams.Any())
            {
                return null;
            }

            var teamsDto = new List<TeamDTO>();
            foreach (var item in teams)
            {
                teamsDto.Add(
                    new TeamDTO()
                    {
                        Key = item.Key,
                        Shield = item.Shield,
                        BestPlayer = new PlayerDTO() { Key = item.BestPlayer.Key, Name = item.BestPlayer.Name, Team = item.BestPlayer.Team, Age = item.BestPlayer.Age },
                        Titles = item.Titles,
                        Name = item.Name,
                        Players = item.Players.Select(x => new PlayerDTO() { Key = x.Key, Name = x.Name, Team = x.Team, Age = x.Age }).ToList()
                    });
            }

            return teamsDto.ToArray();
        }

        public TeamDTO[] FindAll()
        {
            var teamsDto = new List<TeamDTO>();
            foreach (var item in defaultTeams)
            {
                teamsDto.Add(
                    new TeamDTO()
                    {
                        Key = item.Key,
                        Shield = item.Shield,
                        BestPlayer = new PlayerDTO() { Key = item.BestPlayer.Key, Name = item.BestPlayer.Name, Team = item.BestPlayer.Team, Age = item.BestPlayer.Age },
                        Titles = item.Titles,
                        Name = item.Name,
                        Players = item.Players.Select(x => new PlayerDTO() { Key = x.Key, Name = x.Name, Team = x.Team, Age = x.Age }).ToList()
                    });
            }

            return teamsDto.ToArray();
        }

        public TeamDTO FindTeamBy(int key)
        {
            var team = defaultTeams.Where(x => x.Key == key).FirstOrDefault();

            if (team == null)
            {
                return null;
            }

            return new TeamDTO()
            {
                Key = team.Key,
                Shield = team.Shield,
                BestPlayer = new PlayerDTO() { Key = team.BestPlayer.Key, Name = team.BestPlayer.Name, Team = team.BestPlayer.Team, Age = team.BestPlayer.Age },
                Titles = team.Titles,
                Name = team.Name,
                Players = team.Players.Select(x => new PlayerDTO() { Key = x.Key, Name = x.Name, Team = x.Team, Age = x.Age }).ToList()
            };
        }
    }
}
