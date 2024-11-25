using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Infrastructure.Context;

namespace VIARO.Infrastructure.Repositories
{
    public class GradoRepository : Repository<Grado>, IGradoRepository
    {
        public GradoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
