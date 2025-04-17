using LAB05_WillianK.Application.Dtos.Profesores;
using LAB05_WillianK.Domain.Entities;

namespace LAB05_WillianK.Application.Services;

public interface IProfesoresService
{
    Task<IEnumerable<ProfesoresGetDto>> GetAll();
    Task<ProfesoresGetDto> GetById(int id);
    Task<ProfesoresGetDto> Add(ProfesoresPostDto profesoresDto);
    Task<bool> Update(int id, ProfesoresPutDto profesoresDto);
    Task<bool> Delete(int id);
}