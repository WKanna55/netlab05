using LAB05_WillianK.Application.Dtos.Materias;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface IMateriasService : 
    IServiceBase<Materias, MateriasGetDto, MateriasPostDto, MateriasPutDto>
{
    
}