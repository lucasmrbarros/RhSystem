using AutoMapper;
using Layer.Architecture.Domain.Dtos.Vaga;
using Layer.Architecture.Domain.Models;
using System.Linq;

namespace Layer.Infra.Data.Mapping.Profiles
{
    //Perfil de vaga
    public class VagaProfile : Profile
    {
        public VagaProfile()
        {
            CreateMap<CreateVagaDto, Vaga>();
            CreateMap<Vaga, ReadVagaDto>()
                .ForMember(vaga => vaga.Entrevistados, opts => opts
                .MapFrom(vaga => vaga.Entrevistados.Select
                (c => new { c.Id, c.Nome })));
        }
    }
}
