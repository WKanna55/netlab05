namespace LAB05_WillianK.Application.Dtos.Materias;

public class MateriasGetDto
{
    public int IdMateria { get; set; }

    public int? IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}