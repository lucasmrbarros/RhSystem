using AutoMapper;
using Layer.Architecture.Domain.Dtos.Empresa;
using Layer.Architecture.Domain.Models;

namespace Layer.Infra.Data.Mapping.Profiles
{
    public class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<CreateEmpresaDto, Empresa>();
            CreateMap<Empresa, ReadEmpresaDto>();
        }
    }
}
