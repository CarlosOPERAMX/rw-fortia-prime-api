using AutoMapper;
using rw_fortia_prime_api.Entities;

namespace rw_fortia_prime_api.Dtos
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RhPuesto, PuestoDto>();
        }
    }
}
