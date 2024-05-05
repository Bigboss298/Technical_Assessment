using Technical_Assessment_API.Interface.Repository;
using Technical_Assessment_API.Persistence;

namespace Technical_Assessment_API.Implementation.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context) => _context = context;
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

    }
}
