using LAB05_WillianK.Application.Dtos.Cursos;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface ICursosService : IServiceBase<Cursos, CursosGetDto, CursosPostDto, CursosPutDto>
{
    
}