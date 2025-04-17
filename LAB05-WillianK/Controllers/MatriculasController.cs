using LAB05_WillianK.Application.Dtos.Matriculas;
using LAB05_WillianK.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace LAB05_WillianK.Controllers;

[Controller]
[Route("api/[controller]")]
public class MatriculasController : ControllerBase
{
    private readonly IMatriculasService _matriculasService;

    public MatriculasController(IMatriculasService matriculasService)
    {
        _matriculasService = matriculasService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var matriculas = await _matriculasService.GetAll();
        return Ok(matriculas);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var matricula = await _matriculasService.GetById(id);
        if (matricula == null) 
            return NotFound(new { message = $"Matricula con ID {id} no encontrada." });
        return Ok(matricula);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody]MatriculasPostDto matriculasDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var matricula = await _matriculasService.Add(matriculasDto);
        return Ok(matricula);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] MatriculasPutDto matriculasDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var updated = await _matriculasService.Update(id, matriculasDto);
        if (!updated) 
            return NotFound(new { message = $"Matricula con ID {id} no encontrada." });
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var deleted = await _matriculasService.Delete(id);
        if (!deleted)
            return NotFound(new { message = $"Matricula con ID {id} no encontrada." });
        return NoContent();
    }
    
}