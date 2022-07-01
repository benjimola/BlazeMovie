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
           return await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetAiringToday");
        }

        public async Task<IEnumerable<TvShow>> GetOnTheAir()
        {
            return await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetOnTheAir");
        }

        public async Task<IEnumerable<TvShow>> GetPopular()
        {
            return await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetPopular");
        }

        public async Task<IEnumerable<TvShow>> GetTopRated()
        {
            return await Http.GetFromJsonAsync<TvShow[]>($"/api/TvShow/GetTopRated");
        }
    }
}
