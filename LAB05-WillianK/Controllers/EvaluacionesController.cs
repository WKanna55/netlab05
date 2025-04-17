using LAB05_WillianK.Application.Dtos.Evaluaciones;
using LAB05_WillianK.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace LAB05_WillianK.Controllers;

[Controller]
[Route("api/[controller]")]
public class EvaluacionesController : ControllerBase
{
    private readonly IEvaluacionesService _evaluacionesService;

    public EvaluacionesController(IEvaluacionesService evaluacionesService)
    {
        _evaluacionesService = evaluacionesService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var evaluaciones = await _evaluacionesService.GetAll();
        return Ok(evaluaciones);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var evaluacion = await _evaluacionesService.GetById(id);
        if (evaluacion == null) 
            return NotFound(new { message = $"Evaluacion con ID {id} no encontrada." });
        return Ok(evaluacion);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody]EvaluacionesPostDto evaluacionesDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var evaluacion = await _evaluacionesService.Add(evaluacionesDto);
        return Ok(evaluacion);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] EvaluacionesPutDto evaluacionesDto)
    {
        if (!ModelState.IsValid) 
            return BadRequest(ModelState);
        var updated = await _evaluacionesService.Update(id, evaluacionesDto);
        if (!updated) 
            return NotFound(new { message = $"Evaluacion con ID {id} no encontrada." });
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var deleted = await _evaluacionesService.Delete(id);
        if (!deleted)
            return NotFound(new { message = $"Evaluacion con ID {id} no encontrada." });
        return NoContent();
    }
    
}