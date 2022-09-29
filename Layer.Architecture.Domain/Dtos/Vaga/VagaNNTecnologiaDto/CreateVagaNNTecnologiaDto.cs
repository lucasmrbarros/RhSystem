using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dto de criacao de relacionamentos entre vagas e tencologias exigidas

namespace Layer.Architecture.Domain.Dtos.Vaga.VagaNNTecnologiaDto
{
    public class CreateVagaNNTecnologiaDto : BaseCreatTecnologiaNNDto
    {
        [Required]
        public int VagaId { get; set; }
    }
}
