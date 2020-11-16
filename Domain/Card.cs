using System;

namespace Domain
{
    public class Card
    {
        public Guid? Id { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }
}