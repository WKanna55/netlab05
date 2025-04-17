using LAB05_WillianK.Application.Dtos.Estudiantes;
using LAB05_WillianK.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace LAB05_WillianK.Controllers;

[Controller]
[Route("api/[controller]")]
public class EstudiantesController : ControllerBase
{
    private readonly IEstudiantesService _estudiantesService;

    public EstudiantesController(IEstudiantesService estudiantesService)
    {
        _estudiantesService = estudiantesService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var estudiantes = await _estudiantesService.GetAll();
        return Ok(estudiantes);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var estudiante = await _estudiantesService.GetById(id);
        if (estudiante == null) 
            return NotFound(new { message = $"Estudiante con ID {id} no encontrada." });
        return Ok(estudiante);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody]EstudiantesPostDto estudiantesDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var estudiante = await _estudiantesService.Add(estudiantesDto);
        return Ok(estudiante);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] EstudiantesPutDto estudiantesDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var updated = await _estudiantesService.Update(id, estudiantesDto);
        if (!updated) 
            return NotFound(new { message = $"Estudiante con ID {id} no encontrada." });
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var deleted = await _estudiantesService.Delete(id);
        if (!deleted)
            return NotFound(new { message = $"Estudiante con ID {id} no encontrada." });
        return NoContent();
    }
    
}