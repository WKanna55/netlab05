using LAB05_WillianK.Application.Dtos.Asistencias;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface IAsistenciasService : 
    IServiceBase<Asistencias, AsistenciasGetDto, AsistenciasPostDto, AsistenciasPutDto>
{
    
}