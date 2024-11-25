using Microsoft.EntityFrameworkCore;
using School.Domain.Interfaces;
using VIARO.Domain.Entities;
using VIARO.Infrastructure.Context;

namespace VIARO.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);

            return entity;
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            TEntity? entity = await GetByIdAsync(id, cancellationToken);
            
            if( entity is not null )
            {
                _dbContext.Set<TEntity>().Remove(entity);
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Set<TEntity>().ToListAsync(cancellationToken);
        }

        public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id, cancellationToken);
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
