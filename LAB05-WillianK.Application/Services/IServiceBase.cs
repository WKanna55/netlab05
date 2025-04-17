namespace LAB05_WillianK.Application.Services;

public interface IServiceBase<TEntity, TGetDto, TPostDto, TPutDto> where TEntity : class
{
    Task<IEnumerable<TGetDto>> GetAll();
    Task<TGetDto?> GetById(int id);
    Task<TGetDto> Add(TPostDto dto);
    Task<bool> Update(int id, TPutDto dto);
    Task<bool> Delete(int id);
}