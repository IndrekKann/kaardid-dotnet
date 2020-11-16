using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using DAL.Repositories;
using Domain;

namespace WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiveGamesController : ControllerBase
    {
        private readonly ActiveGameRepository _repository;
        private readonly GameService _service;

        public ActiveGamesController(ActiveGameRepository repository, GameService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ActiveGame>> GetActiveGame(Guid id)
        {
            return await _repository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<ActiveGame>> PostActiveGame(JoinCreateGame game)
        {
            var gameId = await _service.CreateJoinGame(game);

            return CreatedAtAction("GetActiveGame", gameId);
        }

    }
}