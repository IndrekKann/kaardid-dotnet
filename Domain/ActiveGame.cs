using System.Collections.Generic;

namespace Domain
{
    public class ActiveGame
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public List<Card> Board { get; set; }
        public List<Player> Players { get; set; }
    }
}