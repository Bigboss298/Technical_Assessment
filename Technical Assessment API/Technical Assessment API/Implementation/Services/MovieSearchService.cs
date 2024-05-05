using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Technical_Assessment_API.Interface.Repository;
using Technical_Assessment_API.Interface.Services;
using Technical_Assessment_API.Model;
using Technical_Assessment_API.Model.Dto;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Technical_Assessment_API.Implementation.Services
{
    public class MovieSearchService : IMovieSearchService
    {
        private readonly HttpClient _httpClient;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISearchQueryRepository _searchQueryRepository;
        private readonly IConfiguration _configuration;
        public MovieSearchService(HttpClient httpClient, ISearchQueryRepository searchQueryRepository, IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _searchQueryRepository = searchQueryRepository;
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }
        public async Task<DetailedMovieDto> GetFullDetailOfMovie(string imdbId)
        {
            if (imdbId is null) throw new Exception("Movie slected has not id");

             string apiKey = _configuration["OMDBApi:ApiKey"];
            var response = await _httpClient.GetAsync($"http://www.omdbapi.com/?i={imdbId}&apikey={apiKey}");
            var responseBody = await response.Content.ReadAsStringAsync();

            var jObject = JObject.Parse(responseBody);
            var responseValue = jObject["Response"].Value<string>();

            if (responseValue == "False")
            {
                return null;
            }

            var movies = JsonConvert.DeserializeObject<DetailedMovieDto>(responseBody);
            return movies;
        }

        public async Task<IEnumerable<MovieByTitleDto>> GetMovieWithTitle(string title)
        {
           if(title is null)
            {
                throw new Exception("search param can't be empty");
            }

            var searchQuery = new SearchQuery
            {
                SearchParam = title,
            };

            var getAllQuery = await _searchQueryRepository.GetAll();

            if (getAllQuery.Count() >= 5)
            {
                var oldestQuery = getAllQuery.Last();
                _searchQueryRepository.Delete(oldestQuery);
            }


            _searchQueryRepository.Insert(searchQuery);

            await _unitOfWork.SaveChangesAsync();

            string apiKey = _configuration["OMDBApi:ApiKey"];

            var response = await _httpClient.GetAsync($"http://www.omdbapi.com/?t={title}&apikey={apiKey}");
             
            var responseBody = await response.Content.ReadAsStringAsync();

            var jObject = JObject.Parse(responseBody);
            var responseValue = jObject["Response"].Value<string>();

            if (responseValue == "False")
            {
                return null;
            }

            var movie = JsonConvert.DeserializeObject<MovieByTitleDto>(responseBody);

            return new List<MovieByTitleDto> { movie };
        }
    }
}
