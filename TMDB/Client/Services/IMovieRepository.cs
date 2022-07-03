using TMDbLib.Objects.Movies;

namespace TMDB.Client.Services
{
    public interface IMovieRepository
    {
        Task<IList<Movie>> GetUpComing();
        Task<IList<Movie>> GetTopRated();
        Task<IList<Movie>> GetNowPlaying();
        Task<IList<Movie>> GetPopular();
        Task<IList<Movie>> GetPopular(int page);
    }
}
