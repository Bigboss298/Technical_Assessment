using Technical_Assessment_API.Model;
using Technical_Assessment_API.Model.Dto;

namespace Technical_Assessment_API.Interface.Services
{
    public interface ISearchQueryServices
    {
        Task<IReadOnlyList<SearchQuery>> GetAll();
    }
}
