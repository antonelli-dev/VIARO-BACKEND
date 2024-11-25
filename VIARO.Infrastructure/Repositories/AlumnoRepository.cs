using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Infrastructure.Context;

namespace VIARO.Infrastructure.Repositories
{
    public class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
    {
        public AlumnoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
