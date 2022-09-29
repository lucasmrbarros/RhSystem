using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dto de leiura entre as vagas e tecnologias exigidas

namespace Layer.Architecture.Domain.Dtos.Vaga.VagaNNTecnologiaDto
{
    public class ReadVagaNNTecnologiaDto : BaseReadTecnologiaNNDto
    {
        public Models.Vaga vaga { get; set; }
    }
}
