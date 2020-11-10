using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BLL.Games.Common
{
    public class Card
    {
        public enum Value
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public enum Suit
        {
            Club, Diamond, Heart, Spade
        }
        
        public static IEnumerable<T> GetValues<T>() {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        public Value value;
        public Suit suit;

        public Card(Value value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public static List<Card> GetDeck()
        {
            var deck = new List<Card>();

            foreach (var cardSuit in GetValues<Suit>())
            {
                foreach (var cardValue in GetValues<Value>())
                {
                    deck.Add(new Card(cardValue, cardSuit));
                }
            }
            
            ShuffleDeck(deck);

            return deck;
        }
        
        public static void ShuffleDeck(List<Card> deck)  
        {  
            Random random = new Random();  
            
            for(var i = deck.Count - 1; i > 1; i--)
            {
                var randomNumber = random.Next(i + 1);  
                Card card = deck[randomNumber];  
                deck[randomNumber] = deck[i];  
                deck[i] = card;
            }
            
        }

        public override string ToString()
        {
            return $"{value} of {suit}s";
        }
    }
}