namespace LAB05_WillianK.Application.Dtos.Asistencias;

public class AsistenciasGetDto
{
    public int IdAsistencia { get; set; }

    public int? IdEstudiante { get; set; }

    public int? IdCurso { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Estado { get; set; }
}