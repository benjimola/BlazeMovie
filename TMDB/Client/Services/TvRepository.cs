using System.Net.Http.Json;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.TvShows;

namespace TMDB.Client.Services
{
    public class TvRepository : ITvRepository
    {
        private readonly HttpClient Http;

        public TvRepository(HttpClient http)
        {
            Http = http;
        }
        public async Task<IEnumerable<TvShow>> GetAiringToday()
        {
           var response = await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetAiringToday");
            if(response == null)
            {
                throw new Exception("");
            }

            return response;
        }

        public async Task<IEnumerable<TvShow>> GetOnTheAir()
        {
            var response = await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetOnTheAir");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;
        }

        public async Task<IEnumerable<TvShow>> GetPopular()
        {
            var response = await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetPopular");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;
        }

        public async Task<IEnumerable<TvShow>> GetTopRated()
        {
            var response = await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetTopRated");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;
        }
    }
}
