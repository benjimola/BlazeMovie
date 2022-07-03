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

        public async Task<IList<Movie>> GetNowPlaying()
        {
            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetNowPlaying");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;
        }

        public async Task<IList<Movie>> GetPopular()
        {

            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetPopular");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;
        }

        public async Task<IList<Movie>> GetPopular(int page)
        {
            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetMovies/{page}");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;
        }

        public async Task<IList<Movie>> GetTopRated()
        {

            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetTopRated");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;
        }

        public async Task<IList<Movie>> GetUpComing()
        {

            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Movie/GetUpcoming");
            if (response == null)
            {
                throw new Exception("");
            }

            return response;


        }
    }
}
