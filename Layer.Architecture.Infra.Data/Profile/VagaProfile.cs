using AutoMapper;
using Layer.Architecture.Domain.Dtos.Vaga;
using Layer.Architecture.Domain.Models;

namespace Layer.Infra.Data.Mapping.Profiles
{
    public class VagaProfile : Profile
    {
        public VagaProfile()
        {
            CreateMap<CreateVagaDto, Vaga>();
            CreateMap<Vaga, ReadVagaDto>();
        }
    }
}
