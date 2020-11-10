using System.Collections.Generic;

namespace BLL.Games.Common
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
        
        public Player(string name)
        {
            this.Name = name;
        }
    }
}