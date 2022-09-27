using AutoMapper;
using Layer.Architecture.Domain.Dtos.EntrevistadoNNVaga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Infra.Data.Profile
{
    public class EntrevistadoNNTecnologiaProfile : AutoMapper.Profile
    {
        public EntrevistadoNNTecnologiaProfile()
        {
            CreateMap<CreateEntrevistadoNNTecnologiaDto, Domain.Models.EntrevistadoNNTecnologias>();
            CreateMap<Domain.Models.EntrevistadoNNTecnologias, ReadEntrevistadoNNTecnologiaDto>();
        }
    }
}
