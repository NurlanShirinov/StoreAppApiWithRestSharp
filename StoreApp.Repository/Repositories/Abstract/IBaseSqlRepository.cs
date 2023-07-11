namespace StoreApp.Repository.Repositories.Abstract
{
    public interface IBaseSqlRepository
    {
        Task TruncateTables();
        Task SaveToDatabase<T>(IEnumerable<T> itemList) where T : class;
    }
}