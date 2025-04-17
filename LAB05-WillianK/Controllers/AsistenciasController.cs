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
    
}