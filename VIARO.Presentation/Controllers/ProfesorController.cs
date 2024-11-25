using Microsoft.AspNetCore.Mvc;
using School.Application.DTOs;
using School.Application.Services;

namespace VIARO.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesorController : ControllerBase
    {
        private readonly ProfesorService _profesorService;

        public ProfesorController(ProfesorService profesorService)
        {
            _profesorService = profesorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            return Ok(await _profesorService.GetAllAsync(cancellationToken));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            return Ok(await _profesorService.GetByIdAsync(id, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProfesorDto dto, CancellationToken cancellationToken)
        {
            return Ok(await _profesorService.AddAsync(dto, cancellationToken));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProfesorDto dto, CancellationToken cancellationToken)
        {
            await _profesorService.UpdateAsync(dto, cancellationToken);
            return Ok(true);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _profesorService.DeleteAsync(id, cancellationToken);
            return Ok(true);
        }
    }
}
