using Ocak.Services.ShoppingCartAPI.Models.Dto;

namespace Ocak.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
