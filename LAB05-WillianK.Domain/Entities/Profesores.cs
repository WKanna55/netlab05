namespace LAB05_WillianK.Domain.Entities;

public partial class Profesores
{
    public int IdProfesor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Especialidad { get; set; }

    public string? Correo { get; set; }
}
