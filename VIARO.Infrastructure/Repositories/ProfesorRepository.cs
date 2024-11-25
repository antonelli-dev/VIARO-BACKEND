using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Infrastructure.Context;

namespace VIARO.Infrastructure.Repositories
{
    public class ProfesorRepository : Repository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
