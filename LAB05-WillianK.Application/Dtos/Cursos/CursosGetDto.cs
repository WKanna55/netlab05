namespace LAB05_WillianK.Application.Dtos.Cursos;

public class CursosGetDto
{
    public int IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Creditos { get; set; }
}