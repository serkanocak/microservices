
using Ocak.Services.OrderAPI.Models.Dto;

namespace Ocak.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
