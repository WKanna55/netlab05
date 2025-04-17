using LAB05_WillianK.Application.Dtos.Matriculas;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface IMatriculasService : 
    IServiceBase<Matriculas, MatriculasGetDto, MatriculasPostDto, MatriculasPutDto>
{
    
}