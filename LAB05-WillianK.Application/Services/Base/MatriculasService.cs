using LAB05_WillianK.Application.Dtos.Matriculas;
using LAB05_WillianK.Domain.Entities;
using LAB05_WillianK.Domain.Interfaces;
using Mapster;

namespace LAB05_WillianK.Application.Services.Base;

/*
 * Servicio usando servicio base y mapster
 */
public class MatriculasService : 
    ServiceBase<Matriculas, MatriculasGetDto, MatriculasPostDto, MatriculasPutDto>, IMatriculasService
{
    public MatriculasService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    public override Matriculas MapToEntity(MatriculasPostDto dto) => dto.Adapt<Matriculas>();
    public override MatriculasGetDto MapToGetDto(Matriculas entity) => entity.Adapt<MatriculasGetDto>();
    public override void MapUpdate(Matriculas entity, MatriculasPutDto dto) => dto.Adapt(entity); // mapea sobre el objeto existent
}