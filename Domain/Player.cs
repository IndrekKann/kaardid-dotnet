using System.Collections.Generic;

namespace Domain
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
    }
}