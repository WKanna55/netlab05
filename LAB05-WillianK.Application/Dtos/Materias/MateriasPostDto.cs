namespace LAB05_WillianK.Application.Dtos.Materias;

public class MateriasPostDto
{
    public int? IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}