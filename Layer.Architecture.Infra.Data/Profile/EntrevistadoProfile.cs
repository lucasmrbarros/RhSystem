using AutoMapper;
using Layer.Architecture.Domain.Dtos.Entrevistado;

using Layer.Architecture.Domain.Models;
namespace Layer.Infra.Data.Mapping.Profiles
{
    public class EntrevistadoProfile : Profile
    {
        public EntrevistadoProfile()
        {
            CreateMap<CreateEntrevistadoDto, Entrevistado>()
             .ForMember(dest => dest.VagaId, act => act.MapFrom(src => src.VagaId));
            CreateMap<Entrevistado, ReadEntrevistadoDto>();

        }
    }
}
