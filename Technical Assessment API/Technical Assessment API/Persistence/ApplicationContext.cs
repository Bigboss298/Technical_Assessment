using Microsoft.EntityFrameworkCore;
using Technical_Assessment_API.Model;

namespace Technical_Assessment_API.Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<SearchQuery> searchQueries { get; set; }
    }
}
