namespace LAB05_WillianK.Application.Dtos.Asistencias;

public class AsistenciasPostDto
{
    public int? IdEstudiante { get; set; }

    public int? IdCurso { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Estado { get; set; }
}