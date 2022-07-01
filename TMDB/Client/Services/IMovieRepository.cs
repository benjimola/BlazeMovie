using TMDbLib.Objects.Movies;

namespace TMDB.Client.Services
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetUpComing();
        Task<IEnumerable<Movie>> GetTopRated();
        Task<IEnumerable<Movie>> GetNowPlaying();
        Task<IEnumerable<Movie>> GetPopular();
    }
}
