using System;

namespace Domain
{
    public class Game : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
    }
}
