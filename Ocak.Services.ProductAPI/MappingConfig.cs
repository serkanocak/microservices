using AutoMapper;
using Ocak.Services.ProductAPI.Models;
using Ocak.Services.ProductAPI.Models.Dto;

namespace Ocak.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
