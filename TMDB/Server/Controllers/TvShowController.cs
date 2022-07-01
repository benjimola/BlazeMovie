using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;
using TMDbLib.Objects.TvShows;

namespace TMDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowController : ControllerBase
    {
        [HttpGet]
        [Route("GetAiringToday")]
        public IActionResult GetAiringToday()
        {
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetTvShowListAsync(TvShowListType.AiringToday, 0, null, default).Result;

            return Ok(response.Results);
        }

        
        [HttpGet]
        [Route("GetTopRated")]
        public IActionResult GetTopRated()
        {
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetTvShowListAsync(TvShowListType.TopRated, 0, null, default).Result;
            return Ok(response.Results);
        }

        [HttpGet]
        [Route("GetOnTheAir")]
        public IActionResult GetOnTheAir()
        {
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetTvShowListAsync(TvShowListType.OnTheAir, 0, null, default).Result;
            return Ok(response.Results);
        }

        [HttpGet]
        [Route("GetPopular")]
        public IActionResult GetPopular()
        {
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetTvShowListAsync(TvShowListType.Popular, 0, null, default).Result;
            return Ok(response.Results);
        }

    }
}
