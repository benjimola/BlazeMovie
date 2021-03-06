using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselController : ControllerBase
    {
        // GET: api/<CarouselController>
        [HttpGet]
        public IActionResult Get()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetMovieNowPlayingListAsync(null, 0, null, default).Result;
            return Ok(response.Results);
        }

       
    }
}
