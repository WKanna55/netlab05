namespace LAB05_WillianK.Application.Dtos.Profesores;

public class ProfesoresGetDto
{
    public int IdProfesor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Especialidad { get; set; }

    public string? Correo { get; set; }
}