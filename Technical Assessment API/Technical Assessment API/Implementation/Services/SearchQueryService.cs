using Technical_Assessment_API.Interface.Repository;
using Technical_Assessment_API.Interface.Services;
using Technical_Assessment_API.Model;
using Technical_Assessment_API.Model.Dto;
using Mapster;

namespace Technical_Assessment_API.Implementation.Services
{
    public class SearchQueryService : ISearchQueryServices
    {
        private readonly ISearchQueryRepository _searchQueryRepository;

        public SearchQueryService(ISearchQueryRepository searchQueryRepository)
        {
            _searchQueryRepository = searchQueryRepository;
        }
        public async Task<IReadOnlyList<SearchQuery>> GetAll()
        {
            var getAllQuery = await _searchQueryRepository.GetAll();
            if(!getAllQuery.Any())
            {
                return new List<SearchQuery>(); 
            }
            return getAllQuery;
        }
    }
}
