using Microsoft.AspNetCore.Mvc;
using Technical_Assessment_API.Interface.Services;

namespace Technical_Assessment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchQueryController : ControllerBase
    {
        private readonly ISearchQueryServices _searchQueryServices;

        public SearchQueryController(ISearchQueryServices searchQueryServices) => _searchQueryServices = searchQueryServices;

        [HttpGet("Queries")]
        public async Task<IActionResult> GetQueries()
        {
            var getQueries = await _searchQueryServices.GetAll();
            return Ok(getQueries);
        }

    }
}
