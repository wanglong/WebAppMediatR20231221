namespace WebAppMediatR.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> IRepository<TEntity>.AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<TEntity>> IRepository<TEntity>.GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IRepository<TEntity>.UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
