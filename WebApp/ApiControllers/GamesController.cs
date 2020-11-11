using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Repositories;
using Domain;

namespace WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly GameRepository _repository;

        public GamesController(GameRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Game>> GetGames()
        {
            return await _repository.GetAll();
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Game>> GetGame(string name)
        {
            return await _repository.GetGameByName(name);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(Guid id, Game game)
        {
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
            await _repository.Add(game);

            return CreatedAtAction("GetGame", new { id = game.Id }, game);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Game>> DeleteGame(Guid id)
        {
            await _repository.Delete(id);

            return NoContent();
        }

    }
}
