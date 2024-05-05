using Microsoft.EntityFrameworkCore;
using Technical_Assessment_API.Interface.Repository;
using Technical_Assessment_API.Model;
using Technical_Assessment_API.Persistence;

namespace Technical_Assessment_API.Implementation.Repository
{
    public class SearchQueryRepository : ISearchQueryRepository
    {
        private readonly ApplicationContext _context;
        public SearchQueryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Delete(SearchQuery searchQuery) => _context.searchQueries.Remove(searchQuery);
        public async Task<IReadOnlyList<SearchQuery>> GetAll()
        {
            return await _context.searchQueries.OrderByDescending(x => x.TimeStamp).ToListAsync();
        }
        public void Insert(SearchQuery searchQuery) => _context.searchQueries.Add(searchQuery);
       
    }
}
