using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using Newtonsoft.Json;

namespace TMDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        [Route("GetMovies/{page:int}")]
        [HttpGet]
        public IActionResult GetMovies(int page)
        {
            List<Movie> movies = new();
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetMoviePopularListAsync(null, page, null, default).Result;

            return Ok(response.Results);
        }
    }
}
