using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Games.Bussijuht;
using DAL.Repositories;
using Domain;

namespace BLL.Services
{
    public class GameService
    {
        private readonly ActiveGameRepository _repository;
        private readonly Bussijuht _game;
        private const int CodeLength = 6;
        private static List<string> Letters { get; set; } = 
            new List<string>(new []
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            });

        public GameService(ActiveGameRepository repository, Bussijuht game)
        {
            _repository = repository;
            _game = game;
        }
        
        public async Task<Guid?> CreateJoinGame(JoinCreateGame game)
        {
            switch (game.Command)
            {
                case "CREATE":
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<BLL.Games.Common.Card, Domain.Card>());
                    var mapper = config.CreateMapper();
                    var bussijuht = new Bussijuht();
                    bussijuht.InitializeGame(game.Players);
                    var board = bussijuht.Board.Select(e => mapper.Map<BLL.Games.Common.Card, Domain.Card>(e)).ToList();

                    // Create a player who joined the game
                    
                    var activeGame = new ActiveGame
                    {
                        Id = Guid.NewGuid(),
                        Name = game.Game,
                        MaxPlayers = game.Players,
                        Code = GenerateRandomGameCode(), 
                        IsActive = true,
                        Board = board,
                        Players = new List<Player>()  // Add player to player list
                    };
                    
                    await _repository.Add(activeGame);

                    return activeGame.Id;
                }
                case "JOIN":
                    // var existingGame = _repository.FindGameByCode(game.Code);
                    // Find the game with id
                    // If game exists, return the id of the game
                    // If game does not exist, return error message
                    break;
                default:
                    // Something went wrong
                    break;
            }

            return null;
        }
        
        // For production use, should check if game with generated code 
        // is active or not to prevent two games having the same code.
        public static string GenerateRandomGameCode()
        {
            var random = new Random();
            var code = new StringBuilder("", CodeLength);
            
            for (var i = 0; i < CodeLength; i++)
            {
                code.Append(Letters[random.Next()]);
            }

            return code.ToString();
        }
        
        
        
    }
}