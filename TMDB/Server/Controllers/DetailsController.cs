using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        // GET: api/<DetailsController>
        [HttpGet("{id}")]
        public async Task <ActionResult<Movie>> Get(int id)
        {
            Movie movie = new Movie();
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            movie = await client.GetMovieAsync(id, MovieMethods.Credits | MovieMethods.Videos | MovieMethods.WatchProviders | MovieMethods.Similar | MovieMethods.ReleaseDates);
            return Ok(movie);
        }

        [Route("GetTrailer/{id:int}")]
        [HttpGet]
        public async Task<ActionResult<Movie>> GetTrailer(int id)
        {
            
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = await client.GetMovieAsync(id, MovieMethods.Videos);
            
            return Ok(response);
        }

    }
}
