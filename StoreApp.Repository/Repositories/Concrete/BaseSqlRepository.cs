using Microsoft.EntityFrameworkCore;
using StoreApp.Core.DAL;
using StoreApp.Repository.Repositories.Abstract;

namespace StoreApp.Repository.Repositories.Concrete
{
    public class BaseSqlRepository : IBaseSqlRepository
    {
        private readonly AppDbContext _context;

        public BaseSqlRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task SaveToDatabase<T>(IEnumerable<T> itemList) where T : class
        {
            await _context.Set<T>().AddRangeAsync(itemList);
            await _context.SaveChangesAsync();
        }
        public async Task TruncateTables()
        {
            await _context.Database.ExecuteSqlRawAsync("EXEC TruncateTables");
        }
    }
}