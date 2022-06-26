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
        public async Task<ActionResult<List<Movie>>> GetNowPlaying()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = await client.GetMovieNowPlayingListAsync(null, 0, null, default);
            return Ok(response.Results);
        }

        [Route("GetUpcoming")]
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetUpcoming()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = await client.GetMovieUpcomingListAsync(null, 0, null, default);
            return Ok(response.Results);
        }
        
        [Route("GetPopular")]
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetPopular()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = await client.GetMoviePopularListAsync(null, 0, null, default);
            return Ok(response.Results);
        }

        [Route("GetTopRated")]
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetTopRated()
        {

            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = await client.GetMovieTopRatedListAsync(null, 0, null, default);
            return Ok(response.Results);
        }
    }
}
