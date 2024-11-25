using Mapster;
using School.Application.DTOs;
using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Application.Utils;
using VIARO.Infrastructure.Repositories;

namespace School.Application.Services
{
    public class AlumnoGradoService
    {
        private readonly IAlumnoGradoRepository _alumnoGradoRepository;

        public AlumnoGradoService(IAlumnoGradoRepository alumnoGradoRepository)
        {
            _alumnoGradoRepository = alumnoGradoRepository;
        }

        public async Task<IEnumerable<AlumnoGradoDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            List<AlumnoGradoDto> alumnoGrados = (await _alumnoGradoRepository.GetAllAsync(cancellationToken)).Adapt<List<AlumnoGradoDto>>();
            return alumnoGrados;
        }

        public async Task<AlumnoGradoDto> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            AlumnoGradoDto? alumnoGrado = (await _alumnoGradoRepository.GetByIdAsync(id, cancellationToken)).Adapt<AlumnoGradoDto>();
            EnsureService.ThrowNotFoundIfIsNull(alumnoGrado, "Relación Alumno-Grado no encontrada.");

            return alumnoGrado;
        }

        public async Task<AlumnoGrado> AddAsync(AlumnoGradoDto alumnoGradoDto, CancellationToken cancellationToken)
        {
            AlumnoGrado alumnoGrado = alumnoGradoDto.Adapt<AlumnoGrado>();
            await _alumnoGradoRepository.AddAsync(alumnoGrado, cancellationToken);
            await _alumnoGradoRepository.SaveChangesAsync(cancellationToken);

            return alumnoGrado;
        }

        public async Task UpdateAsync(AlumnoGradoDto alumnoGradoDto, CancellationToken cancellationToken)
        {
            AlumnoGrado alumnoGrado = alumnoGradoDto.Adapt<AlumnoGrado>();

            _alumnoGradoRepository.Update(alumnoGrado);
            await _alumnoGradoRepository.SaveChangesAsync(cancellationToken);

        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            await _alumnoGradoRepository.DeleteAsync(id, cancellationToken);
            await _alumnoGradoRepository.SaveChangesAsync(cancellationToken);
        }
    }
}
