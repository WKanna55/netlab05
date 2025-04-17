using LAB05_WillianK.Application.Dtos.Matriculas;
using LAB05_WillianK.Application.Dtos.Profesores;
using LAB05_WillianK.Domain.Entities;
using LAB05_WillianK.Domain.Interfaces;
using Mapster;

namespace LAB05_WillianK.Application.Services.Base;
/*
 * Servicio convencional -> sin usar servicio base y usando mapster
 */
public class ProfesoresService : IProfesoresService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProfesoresService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<ProfesoresGetDto>> GetAll()
    {
        var profesores = await _unitOfWork.Repository<Profesores>().GetAll();
        var profesoresDto = profesores.Adapt<IEnumerable<ProfesoresGetDto>>();
        return profesoresDto;
    }

    public async Task<ProfesoresGetDto> GetById(int id)
    {
        var profesor = await _unitOfWork.Repository<Profesores>().GetById(id);
        return profesor.Adapt<ProfesoresGetDto>();
    }

    public async Task<ProfesoresGetDto> Add(ProfesoresPostDto profesoresDto)
    {
        var profesor = profesoresDto.Adapt<Profesores>();
        await _unitOfWork.Repository<Profesores>().Add(profesor);
        await _unitOfWork.Complete();
        return profesor.Adapt<ProfesoresGetDto>();
    }

    public async Task<bool> Update(int id, ProfesoresPutDto profesoresDto)
    {
        var profesor = await _unitOfWork.Repository<Profesores>().GetById(id);
        if (profesor == null) 
            return false;
        profesoresDto.Adapt(profesor); // mapster actualizar datos
        await _unitOfWork.Repository<Profesores>().Update(profesor);
        await _unitOfWork.Complete();
        return true;
    }

    public async Task<bool> Delete(int id)
    {
        var deleted = await _unitOfWork.Repository<Profesores>().Delete(id);
        if (!deleted) 
            return false;
        await _unitOfWork.Complete();
        return true;
        
    }
    
}