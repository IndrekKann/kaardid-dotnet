using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Games.Common;

namespace BLL.Games.Bussijuht
{
    public class Bussijuht
    {
        public List<Card> deck;
        public List<Player> players = new List<Player>();
        public List<Card> board = new List<Card>();

        public Bussijuht(List<Card> deck)
        {
            this.deck = deck;
        }

        public void InitializeBoard()
        {
            var deckQueue = new Queue<Card>(deck);
            var boardQueue = new Queue<Card>(board);
            
            for (var i = 0; i < 15 ; i++)
            {
                boardQueue.Enqueue(deckQueue.Dequeue());
            }

            deck = deckQueue.ToList();
            board = boardQueue.ToList();
        }

        public void InitializeHands(int amountOfPlayers)
        {
            for (var i = 0; i < amountOfPlayers; i++)
            {
                players.Add(new Player($"Player {i + 1}"));
            }

            foreach (var card in deck)
            {
                
            }
        }

    }
}