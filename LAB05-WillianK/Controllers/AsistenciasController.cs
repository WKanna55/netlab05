using LAB05_WillianK.Application.Dtos.Asistencias;
using LAB05_WillianK.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace LAB05_WillianK.Controllers;

[Controller]
[Route("api/[controller]")]
public class AsistenciasController : ControllerBase
{
    private readonly IAsistenciasService _asistenciasService;

    public AsistenciasController(IAsistenciasService asistenciasService)
    {
        _asistenciasService = asistenciasService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var asistencias = await _asistenciasService.GetAll();
        return Ok(asistencias);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var asistencia = await _asistenciasService.GetById(id);
        if (asistencia == null) 
            return NotFound(new { message = $"Asistencia con ID {id} no encontrada." });
        return Ok(asistencia);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody]AsistenciasPostDto asistenciasDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var asistencia = await _asistenciasService.Add(asistenciasDto);
        return Ok(asistencia);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] AsistenciasPutDto asistenciasDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var updated = await _asistenciasService.Update(id, asistenciasDto);
        if (!updated) 
            return NotFound(new { message = $"Asistencia con ID {id} no encontrada." });
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var deleted = await _asistenciasService.Delete(id);
        if (!deleted)
            return NotFound(new { message = $"Asistencia con ID {id} no encontrada." });
        return NoContent();
    }
}