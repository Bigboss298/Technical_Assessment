using Technical_Assessment_API.Model.Dto;

namespace Technical_Assessment_API.Interface.Services
{
    public interface IMovieSearchService
    {
        Task<IEnumerable<MovieByTitleDto>> GetMovieWithTitle(string title);
        Task<DetailedMovieDto> GetFullDetailOfMovie(string imdbId);
    }
}
