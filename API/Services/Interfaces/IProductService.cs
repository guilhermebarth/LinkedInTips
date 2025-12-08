namespace API.Services.Interfaces
{
    // This is not following Clean Architecture
    public interface IProductService
    {
        Task<object> GetByIdAsync(Guid id);
    }
}
