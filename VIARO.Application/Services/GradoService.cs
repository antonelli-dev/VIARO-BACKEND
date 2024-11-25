using Mapster;
using School.Application.DTOs;
using School.Domain.Entities;
using School.Domain.Interfaces;
using VIARO.Application.Utils;
using VIARO.Infrastructure.Repositories;

namespace School.Application.Services
{
    public class GradoService
    {
        private readonly IGradoRepository _gradoRepository;

        public GradoService(IGradoRepository gradoRepository)
        {
            _gradoRepository = gradoRepository;
        }

        public async Task<IEnumerable<GradoDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            List<GradoDto> grados = (await _gradoRepository.GetAllAsync(cancellationToken)).Adapt<List<GradoDto>>();

            return grados;
        }

        public async Task<GradoDto> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            GradoDto grado = (await _gradoRepository.GetByIdAsync(id, cancellationToken)).Adapt<GradoDto>();
            EnsureService.ThrowNotFoundIfIsNull(grado, "Grado no encontrado.");

            return grado;
        }

        public async Task<Grado> AddAsync(GradoDto gradoDto, CancellationToken cancellationToken)
        {
            Grado grado = gradoDto.Adapt<Grado>();
            await _gradoRepository.AddAsync(grado, cancellationToken);
            await _gradoRepository.SaveChangesAsync(cancellationToken);

            return grado;
        }

        public async Task UpdateAsync(GradoDto gradoDto, CancellationToken cancellationToken)
        {
            Grado grado = gradoDto.Adapt<Grado>();

            _gradoRepository.Update(grado);
            await _gradoRepository.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            await _gradoRepository.DeleteAsync(id, cancellationToken);
            await _gradoRepository.SaveChangesAsync(cancellationToken);
        }
    }
}
