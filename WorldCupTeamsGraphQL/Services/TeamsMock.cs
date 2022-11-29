using System.Collections.Generic;
using WorldCupTeamsGraphQL.Domains;

namespace WorldCupTeamsGraphQL.Services
{
    public static class TeamsMock
    {
        public static List<Team> CreatDefaultTeams()
        {
            var teams = new List<Team>();

            var brazilTeam = new Team(1, "Brasil", 5, "https://cassiozirpoli.com.br/wp-content/uploads/2019/04/cbf_escudo_evolucao_ate_2019_700_1.jpg", new Player(1, "Neymar", "PSG", 28),
                new List<Player>() {
                    new Player(1, "Neymar", "PSG", 28),
                    new Player(2, "Alysson", "Liverpool", 32),
                    new Player(3, "Richarlison", "Totehan", 21),
                    new Player(4, "Pedro", "Flamengo", 24),
                    new Player(5, "Vini Jr", "Real Madrid", 23),
                    new Player(6, "Marquinhos", "PSG", 28)
                });

            teams.Add(brazilTeam);

            var argentinaTeam = new Team(2, "Argentina", 2, "https://images.mantosdofutebol.com.br/wp-content/uploads/2022/04/Camisa-titular-da-Argentina-2022-2023-Adidas-a-1170x650.jpg",
                new Player(7, "Messi", "PSG", 32),
                new List<Player>() {
                    new Player(7, "Messi", "PSG", 32),
                    new Player(8, "Martínez", "Internazionale", 32),
                    new Player(9, "Di María", "Juventus", 21),
                    new Player(10, "Dybala", "Roma", 24),
                    new Player(11, "Paredes", "Juventus", 23),
                    new Player(12, "Ocampos", "Ajax", 28)
                });

            teams.Add(argentinaTeam);

            var franceTeam = new Team(3, "França", 4, "https://assets.goal.com/v3/assets/bltcc7a7ffd2fbf71f5/bltca13cd8a4d76696a/60ddf46cbbd30c0f67ea04d3/ac0ad3d06c0e773108df5c1fd3c924d90859f963.jpg?quality=80&format=pjpg&auto=webp&width=1000",
            new Player(13, "Karim Benzema", "Real Madrid", 32),
            new List<Player>() {
                    new Player(13, "Karim Benzema", "Real Madrid", 32),
                    new Player(8, "Paul Pogba", "Juventus", 32),
                    new Player(9, "Antoine Griezmann", "Atlético de Madrid", 21),
                    new Player(10, "Dembélé", "Barcelona", 24)
            });

            teams.Add(franceTeam);

            return teams;
        }
    }
}
