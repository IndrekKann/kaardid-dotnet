using System;
using System.Collections.Generic;

namespace Domain
{
    public class Player : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
    }
}