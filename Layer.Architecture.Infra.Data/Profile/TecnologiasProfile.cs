using AutoMapper;
using Layer.Architecture.Domain.Dtos.Tecnologia;
using Layer.Architecture.Domain.Dtos.Vaga;
using Layer.Architecture.Domain.Models;

namespace Layer.Infra.Data.Mapping.Profiles
{
    public class TecnologiasProfile : Profile
    {
        //Perfil de tecnologias
        public TecnologiasProfile()
        {
            CreateMap<CreateTecnologiaDto, Tecnologias>();
            CreateMap<Tecnologias, ReadVagaDto>();
        }
    }
}
