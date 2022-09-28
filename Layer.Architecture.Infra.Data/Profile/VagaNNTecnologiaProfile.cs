using Layer.Architecture.Domain.Dtos.Vaga.VagaNNTecnologiaDto;
using Layer.Architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Infra.Data.Profile
{
    public class VagaNNTecnologiaProfile : AutoMapper.Profile
    {
        public VagaNNTecnologiaProfile()
        {
            CreateMap<CreateVagaNNTecnologiaDto, VagaNNTecnologias>();
            CreateMap<VagaNNTecnologias, ReadVagaNNTecnologiaDto>();
            CreateMap<UpdateVagaNNTecnologiaDto, VagaNNTecnologias>();
        }
    }
}
