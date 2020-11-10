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
            game.InitializeHands(4);
            
            foreach (var card in game.board)
            {
                Console.Write(card + ", ");
            }

            Console.WriteLine();

            foreach (var player in game.players)
            {
                Console.WriteLine(player.Name);
                
                foreach (var card in player.Hand)
                {
                    Console.Write(card + ", ");
                }
                
                Console.WriteLine();
            }
            
        }
    }
}