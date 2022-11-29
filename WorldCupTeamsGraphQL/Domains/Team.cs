using System.Collections.Generic;

namespace WorldCupTeamsGraphQL.Domains
{
    public class Team
    {
        private List<Player> playersList = new List<Player>();

        public int Key { get; private set; }
        public string Name { get; private set; }
        public int Titles { get; private set; }
        public string Shield { get; private set; }
        public Player BestPlayer { get; private set; }
        public Player[] Players { get { return playersList.ToArray(); } }

        public Team(int key, string name, int titles, string shield, Player bestPlayer, List<Player> players)
        {
            Key = key;
            Name = name;
            Titles = titles;
            Shield = shield;
            BestPlayer = bestPlayer;
            playersList = players;
        }
    }
}
