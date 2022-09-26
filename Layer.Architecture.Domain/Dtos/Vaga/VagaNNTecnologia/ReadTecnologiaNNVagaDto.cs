using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Dtos.Vaga.VagaNNTecnologia
{
    public class ReadTecnologiaNNVagaDto : BaseReadTecnologiaNNDto
    {
        public Models.Vaga Vagas { get; set; }
    }
}
