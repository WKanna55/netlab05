using LAB05_WillianK.Application.Dtos.Profesores;
using LAB05_WillianK.Domain.Entities;
using LAB05_WillianK.Domain.Interfaces;

namespace LAB05_WillianK.Application.Services.Base;

public class ProfesoresService : 
    ServiceBase<Profesores, ProfesoresGetDto, ProfesoresPostDto, ProfesoresPutDto>, 
    IProfesoresService
{
    public ProfesoresService(IUnitOfWork unitOfWork) : base(unitOfWork) {}


    public override Profesores MapToEntity(ProfesoresPostDto dto)
    {
        return new Profesores
        {
            Nombre = dto.Nombre,
            Especialidad = dto.Especialidad,
            Correo = dto.Correo
        };
    }

    public override ProfesoresGetDto MapToGetDto(Profesores entity)
    {
        return new ProfesoresGetDto
        {
            IdProfesor = entity.IdProfesor,
            Nombre = entity.Nombre,
            Especialidad = entity.Especialidad,
            Correo = entity.Correo
        };
    }

    public override void MapUpdate(Profesores entity, ProfesoresPutDto dto)
    {
        entity.Nombre = dto.Nombre;
        entity.Especialidad = dto.Especialidad;
        entity.Correo = dto.Correo;
    }
}