using System;
using System.Collections.Generic;
using BLL.Games.Bussijuht;
using BLL.Games.Common;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = Card.GetDeck();
            Bussijuht game = new Bussijuht(deck);
            game.InitializeBoard();
            
            foreach (var card in game.board)
            {
                Console.WriteLine(card);
            }
            
            Console.WriteLine(game.board.Count);
            Console.WriteLine(game.deck.Count);
        }
    }
}