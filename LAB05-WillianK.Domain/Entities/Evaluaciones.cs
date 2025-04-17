﻿namespace LAB05_WillianK.Domain.Entities;

public partial class Evaluaciones
{
    public int IdEvaluacion { get; set; }

    public int? IdEstudiante { get; set; }

    public int? IdCurso { get; set; }

    public decimal? Calificacion { get; set; }

    public DateOnly? Fecha { get; set; }

    public virtual Cursos? IdCursoNavigation { get; set; }

    public virtual Estudiantes? IdEstudianteNavigation { get; set; }
}
