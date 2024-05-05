using Microsoft.AspNetCore.Mvc;
using Technical_Assessment_API.Interface.Services;

namespace Technical_Assessment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieSearchController : ControllerBase
    {
        private readonly IMovieSearchService _movieSearchService;
        private readonly ILogger<MovieSearchController> _logger;    

        public MovieSearchController(IMovieSearchService movieSearchService, ILogger<MovieSearchController> logger)
        {
            _movieSearchService = movieSearchService;
            _logger = logger;
        }
        [HttpGet("Title")]
        public async Task<IActionResult> GetMovieWithTitle(string title)
        {
            try
            {
                var movie = await _movieSearchService.GetMovieWithTitle(title);
                if(movie == null)
                {
                    return Ok(new { Response = "False", Error = "Movie not Found!!!" });
                }
                return Ok(movie);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching movie with title");
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("imdbId")]
        public async Task<IActionResult> GetFullDetailOfMovie(string imdbId)
        {
            try
            {
                var detailedInfo = await _movieSearchService.GetFullDetailOfMovie(imdbId);
                return Ok(detailedInfo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching deatiled information of movies");
                return StatusCode(500, ex.Message);
            }
        }
    }
}
