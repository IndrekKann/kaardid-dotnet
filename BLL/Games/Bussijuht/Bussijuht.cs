using System.Collections.Generic;
using System.Linq;
using BLL.Games.Common;

namespace BLL.Games.Bussijuht
{
    public class Bussijuht
    {
        public List<Card> Deck = Card.GetDeck();
        public List<Player> Players = new List<Player>();
        public List<Card> Board = new List<Card>();

        public Bussijuht()
        {
        }

        public void InitializeGame(int amountOfPlayers)
        {
            InitializeBoard();
            InitializeHands(amountOfPlayers);
        }

        private void InitializeBoard()
        {
            var deckQueue = new Queue<Card>(Deck);
            var boardQueue = new Queue<Card>(Board);
            
            for (var i = 0; i < 15 ; i++)
            {
                boardQueue.Enqueue(deckQueue.Dequeue());
            }

            Deck = deckQueue.ToList();
            Board = boardQueue.ToList();
        }

        private void InitializeHands(int amountOfPlayers)
        {
            for (var i = 0; i < amountOfPlayers; i++)
            {
                Players.Add(new Player($"Player {i + 1}"));
            }

            for (var i = 0; i < Deck.Count; i++)
            {
                Players[i % Players.Count].Hand.Add(Deck[i]);
            }
            
        }

    }
}