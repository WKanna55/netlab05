using LAB05_WillianK.Application.Dtos.Evaluaciones;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface IEvaluacionesService : 
    IServiceBase<Evaluaciones, EvaluacionesGetDto, EvaluacionesPostDto, EvaluacionesPutDto>
{
    
}