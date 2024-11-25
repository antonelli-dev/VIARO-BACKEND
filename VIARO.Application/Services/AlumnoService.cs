using Mapster;
using School.Application.DTOs;
using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Application.Utils;

namespace School.Application.Services
{
    public class AlumnoService
    {
        private readonly IAlumnoRepository _alumnoRepository;

        public AlumnoService(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        public async Task<IEnumerable<AlumnoDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            List<AlumnoDto> alumnos = (await _alumnoRepository.GetAllAsync(cancellationToken)).Adapt<List<AlumnoDto>>();

            return alumnos;
        }

        public async Task<AlumnoDto> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            AlumnoDto? alumno = (await _alumnoRepository.GetByIdAsync(id, cancellationToken)).Adapt<AlumnoDto>();
            EnsureService.ThrowNotFoundIfIsNull(alumno, "Alumno no encontrado.");

            return alumno;
        }

        public async Task<Alumno> AddAsync(AlumnoDto alumnoDto, CancellationToken cancellationToken)
        {
            Alumno alumno = alumnoDto.Adapt<Alumno>();
            await _alumnoRepository.AddAsync(alumno, cancellationToken);
            await _alumnoRepository.SaveChangesAsync(cancellationToken);

            return alumno;
        }

        public async Task UpdateAsync(AlumnoDto alumnoDto, CancellationToken cancellationToken)
        {
            Alumno alumno = alumnoDto.Adapt<Alumno>();
            _alumnoRepository.Update(alumno);

            await _alumnoRepository.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            await _alumnoRepository.DeleteAsync(id, cancellationToken);
            await _alumnoRepository.SaveChangesAsync(cancellationToken);
        }
    }
}
