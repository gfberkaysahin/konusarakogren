using AutoMapper;
using EntityLayer;
using KonusarakOgrenUILayer.DTO;

namespace KonusarakOgrenUILayer.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductListDTO>()
            .ForMember(dest => dest.Name, source => source.MapFrom(src => src.Name))
            .ForMember(dest => dest.Color, source => source.MapFrom(src => src.Color))
            .ForMember(dest => dest.Description, source => source.MapFrom(src => src.Description))
            .ForMember(dest => dest.Price, source => source.MapFrom(src => src.Price))
            .ForMember(dest => dest.DiscountPercante, source => source.MapFrom(src => src.DiscountPercante))
            .ForMember(dest => dest.CreatedDate, source => source.MapFrom(src => src.CreatedDate))
            .ForMember(dest => dest.Size, source => source.MapFrom(src => src.Size));
    }
    
}