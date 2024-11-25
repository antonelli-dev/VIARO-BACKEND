using Microsoft.AspNetCore.Mvc;
using School.Application.DTOs;
using School.Application.Services;

namespace VIARO.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradoController : ControllerBase
    {
        private readonly GradoService _gradoService;

        public GradoController(GradoService gradoService)
        {
            _gradoService = gradoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            return Ok(await _gradoService.GetAllAsync(cancellationToken));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            return Ok(await _gradoService.GetByIdAsync(id, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Add(GradoDto dto, CancellationToken cancellationToken)
        {
            return Ok(await _gradoService.AddAsync(dto, cancellationToken));
        }

        [HttpPut]
        public async Task<IActionResult> Update(GradoDto dto, CancellationToken cancellationToken)
        {
            await _gradoService.UpdateAsync(dto, cancellationToken);
            return Ok(true);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _gradoService.DeleteAsync(id, cancellationToken);
            return Ok(true);
        }
    }
}
