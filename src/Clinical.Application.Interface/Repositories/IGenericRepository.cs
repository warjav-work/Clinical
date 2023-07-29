namespace Clinical.Application.Interface.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(string storeProcedure);
        Task<T> GetByIdAsync(string storeProcdure, object parameter);
        Task<bool> ExecAsync(string storeProcedure, object parameters);
    }
}
