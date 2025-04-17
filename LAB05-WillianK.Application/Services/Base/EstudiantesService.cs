using LAB05_WillianK.Application.Dtos.Estudiantes;
using LAB05_WillianK.Domain.Entities;
using LAB05_WillianK.Domain.Interfaces;

namespace LAB05_WillianK.Application.Services.Base;

public class EstudiantesService : 
    ServiceBase<Estudiantes, EstudiantesGetDto, EstudiantesPostDto, EstudiantesPutDto> , IEstudiantesService
{
    public EstudiantesService(IUnitOfWork unitOfWork) : base(unitOfWork) { }


    public override Estudiantes MapToEntity(EstudiantesPostDto dto)
    {
        return new Estudiantes
        {
            Nombre = dto.Nombre,
            Edad = dto.Edad,
            Direccion = dto.Direccion,
            Telefono = dto.Telefono,
            Correo = dto.Correo
        };
    }

    public override EstudiantesGetDto MapToGetDto(Estudiantes entity)
    {
        return new EstudiantesGetDto
        {
            IdEstudiante = entity.IdEstudiante,
            Nombre = entity.Nombre,
            Edad = entity.Edad,
            Direccion = entity.Direccion,
            Telefono = entity.Telefono,
            Correo = entity.Correo
        };
    }

    public override void MapUpdate(Estudiantes entity, EstudiantesPutDto dto)
    {
        entity.Nombre = dto.Nombre;
        entity.Edad = dto.Edad;
        entity.Direccion = dto.Direccion;
        entity.Telefono = dto.Telefono;
        entity.Correo = dto.Correo;
    }
}