using Mapster;
using School.Application.DTOs;
using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Application.Utils;

namespace School.Application.Services
{
    public class ProfesorService
    {
        private readonly IProfesorRepository _profesorRepository;

        public ProfesorService(IProfesorRepository profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }

        public async Task<IEnumerable<ProfesorDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            List<ProfesorDto> profesores = (await _profesorRepository.GetAllAsync(cancellationToken)).Adapt<List<ProfesorDto>>();

            return profesores;
        }

        public async Task<ProfesorDto> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            ProfesorDto? profesor = (await _profesorRepository.GetByIdAsync(id, cancellationToken)).Adapt<ProfesorDto>();
            EnsureService.ThrowNotFoundIfIsNull(profesor, "Profesor no encontrado.");

            return profesor;
        }

        public async Task<Profesor> AddAsync(ProfesorDto profesorDto, CancellationToken cancellationToken)
        {
            Profesor profesor = profesorDto.Adapt<Profesor>();
            await _profesorRepository.AddAsync(profesor, cancellationToken);
            await _profesorRepository.SaveChangesAsync(cancellationToken);
            return profesor;
        }

        public async Task UpdateAsync(ProfesorDto profesorDto, CancellationToken cancellationToken)
        {
            Profesor profesor = profesorDto.Adapt<Profesor>();

            _profesorRepository.Update(profesor);
            await _profesorRepository.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            await _profesorRepository.DeleteAsync(id, cancellationToken);
            await _profesorRepository.SaveChangesAsync(cancellationToken);
        }
    }
}
