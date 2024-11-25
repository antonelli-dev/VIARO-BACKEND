using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Infrastructure.Context;

namespace VIARO.Infrastructure.Repositories
{
    public class AlumnoGradoRepository : Repository<AlumnoGrado>, IAlumnoGradoRepository
    {
        public AlumnoGradoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
