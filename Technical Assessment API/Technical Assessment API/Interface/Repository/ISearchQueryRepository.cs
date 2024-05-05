using Technical_Assessment_API.Model;

namespace Technical_Assessment_API.Interface.Repository
{
    public interface ISearchQueryRepository
    {
        void Insert(SearchQuery searchQuery);
        void Delete(SearchQuery searchQuery);
        //void Update(SearchQuery searchQuery);
        Task<IReadOnlyList<SearchQuery>> GetAll();
    }
}
