using LAB05_WillianK.Application.Dtos.Estudiantes;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface IEstudiantesService : IServiceBase<Estudiantes, EstudiantesGetDto, EstudiantesPostDto, EstudiantesPutDto>
{
    
}