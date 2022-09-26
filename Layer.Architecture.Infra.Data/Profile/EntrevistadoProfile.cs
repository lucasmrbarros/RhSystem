using AutoMapper;
using Layer.Architecture.Domain.Dtos.Entrevistado;
using Layer.Architecture.Domain.Dtos.EntrevistadoNNVaga;
using Layer.Architecture.Domain.Models;
using System.IO.Pipelines;

namespace Layer.Infra.Data.Mapping.Profiles
{
    public class EntrevistadoProfile : Profile
    {
        public EntrevistadoProfile()
        {
            CreateMap<CreateEntrevistadoDto, Entrevistado>();
            CreateMap<Entrevistado, ReadEntrevistadoDto>();
            CreateMap<CreateEntrevistadoNNTecnologiaDto, EntrevistadoNNTecnologias>();
            CreateMap<EntrevistadoNNTecnologias, ReadEntrevistadoNNTecnologiaDto>();
        }
    }
}
