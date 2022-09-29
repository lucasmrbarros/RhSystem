using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Dtos.Vaga.VagaNNTecnologiaDto
{
    //Dto de autalizacao de pesos das tecnologias para as vagas
    public class UpdateVagaNNTecnologiaDto
    {
        [Required]
        public int Pontos { get; set; }
    }
}
