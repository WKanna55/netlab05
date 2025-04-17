namespace LAB05_WillianK.Application.Dtos.Estudiantes;

public class EstudiantesGetDto
{
    public int IdEstudiante { get; set; }

    public string Nombre { get; set; } = null!;

    public int Edad { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }
}