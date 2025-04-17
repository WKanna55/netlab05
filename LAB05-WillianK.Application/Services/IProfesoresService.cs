using LAB05_WillianK.Application.Dtos.Profesores;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface IProfesoresService : 
    IServiceBase<Profesores, ProfesoresGetDto, ProfesoresPostDto, ProfesoresPutDto>
{
    
}