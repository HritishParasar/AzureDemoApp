using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("getAllMovie")]
        public async Task<IActionResult> GetMovies()
        {
            var movies = new List<string> { "Dhurandhar", "Animal", "De De Pyar De 2", "Saiyara", "Param Sundari" };
            return Ok(movies);
        }
        [HttpGet("getMovieById/{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var movies = new List<string> { "Dhurandhar", "Animal", "De De Pyar De 2", "Saiyara", "Param Sundari" };
            if (id < 0 || id >= movies.Count)
            {
                return NotFound("Movie not found");
            }
            return Ok(movies[id]);
        }
    }
}
