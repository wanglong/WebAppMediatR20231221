namespace WebAppMediatR.Data
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<IQueryable<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
