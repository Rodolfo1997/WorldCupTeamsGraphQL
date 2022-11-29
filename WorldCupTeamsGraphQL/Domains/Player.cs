namespace WorldCupTeamsGraphQL.Domains
{
    public class Player
    {
        public int Key { get; private set; }
        public string Name { get; private set; }
        public string Team { get; private set; }
        public int Age { get; private set; }

        public Player(int key, string name, string team, int age)
        {
            Key = key;
            Name = name;
            Team = team;
            Age = age;
        }
    }
}