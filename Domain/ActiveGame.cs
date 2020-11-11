using System;
using System.Collections.Generic;

namespace Domain
{
    public class ActiveGame : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public bool IsActive { get; set; }
        public List<Card> Board { get; set; }
        public List<Player> Players { get; set; }
    }
}