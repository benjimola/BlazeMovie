using System.Net.Http.Json;
using TMDbLib.Objects.Movies;


namespace TMDB.Client.Services
{
    public class MovieRepository : IMovieRepository
    {
        private readonly HttpClient Http;

        public MovieRepository(HttpClient http)
        {
            Http = http;
        }

        public async Task<IEnumerable<Movie>> GetNowPlaying()
        {
            return await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetNowPlaying");
        }

        public async Task<IEnumerable<Movie>> GetPopular()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetPopular");
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<Movie>> GetTopRated()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetTopRated");
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<Movie>> GetUpComing()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetUpcoming");
#pragma warning restore CS8603 // Possible null reference return.

        }
    }
}
