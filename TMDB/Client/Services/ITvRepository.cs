using TMDbLib.Objects.TvShows;

namespace TMDB.Client.Services
{
    public interface ITvRepository
    {
        Task<IEnumerable<TvShow>> GetAiringToday();
        Task<IEnumerable<TvShow>> GetOnTheAir();
        Task<IEnumerable<TvShow>> GetPopular();
        Task<IEnumerable<TvShow>> GetTopRated();
    }
}
