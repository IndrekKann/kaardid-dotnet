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
            var game = new Bussijuht();
            
            game.InitializeGame(4);
            
            foreach (var card in game.Board)
            {
                Console.Write(card + ", ");
            }

            Console.WriteLine();

            foreach (var player in game.Players)
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