using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHerosApi.Services.SuperHeroService;

namespace SuperHerosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class SuperHeroController : ControllerBase // SuperHeroController handles HTTP requests related to superhero entities.
    {
        private readonly ISuperHeroService _superHeroService;

        
        public SuperHeroController(ISuperHeroService superHeroService) // Constructor to inject the dependency of ISuperHeroService.
        {
            _superHeroService = superHeroService;
        }

        // GET api/SuperHero
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return _superHeroService.GetAllHeroes();
        }

        // GET api/SuperHero/{id}
        [HttpGet("{id}")]
        // Action method to retrieve a single superhero by ID.
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var result = _superHeroService.GetSingleHero(id);
            if (result is null)
                return NotFound("Superhero not found!");
            return Ok(result);
        }

        // POST api/SuperHero
        [HttpPost]
        // Action method to add a new superhero.
        public async Task<ActionResult<SuperHero>> AddHero(SuperHero hero)
        {
            var result = _superHeroService.AddHero(hero);
            return Ok(result);
        }

        // PUT api/SuperHero/{id}
        [HttpPut("{id}")]
        // Action method to update an existing superhero by ID.
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var result = _superHeroService.UpdateHero(id, request);
            if (result is null)
                return NotFound("Superhero not found!");
            return Ok(result);
        }

        // DELETE api/SuperHero/{id}
        [HttpDelete("{id}")]
        // Action method to delete a superhero by ID.
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            if (result is null)
                return NotFound("Superhero not found!");
            return Ok(result);
        }
    }
}
