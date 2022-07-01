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
        //[Route("GetTotalPage/{page:int}")]
        //[HttpGet]
        //public IActionResult GetTotalPage(int page)
        //{
        //    TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
        //    var response = client.GetMoviePopularListAsync(null, page, null, default);
        //    return Ok(response.Result.TotalResults);
        //}

        [Route("GetMovies/{page:int}")]
        [HttpGet]
        public async Task<ActionResult<Movie>> GetMovies(int page)
        {
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = await client.GetMoviePopularListAsync(null, page, null, default );
            return Ok(response.Results);
        }

        [Route("GetNowPlaying")]
        [HttpGet]
        public IActionResult GetNowPlaying()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetMovieNowPlayingListAsync(null, 0, null, default).Result;
            return Ok(response.Results);
        }

        [Route("GetUpcoming")]
        [HttpGet]
        public IActionResult GetUpcoming()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetMovieUpcomingListAsync(null, 0, null, default).Result;
            return Ok(response.Results);
        }



        [Route("GetPopular")]
        [HttpGet]
        public IActionResult GetPopular()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetMoviePopularListAsync(null, 0, null, default).Result;
            return Ok(response.Results);
        }

        [Route("GetTopRated")]
        [HttpGet]
        public IActionResult GetTopRated()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetMovieTopRatedListAsync(null, 0, null, default).Result;
            return Ok(response.Results);
        }
    }
}
