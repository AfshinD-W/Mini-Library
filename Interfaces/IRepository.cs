namespace Minilibrary.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>?> GetAllAsync();
        Task<T> CreateAsync(T entity);
        Task<ICollection<T>> BulkCreateAsync(IEnumerable<T> entities);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
