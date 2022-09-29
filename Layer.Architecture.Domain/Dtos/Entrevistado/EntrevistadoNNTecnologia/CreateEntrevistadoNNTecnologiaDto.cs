using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Dtos.EntrevistadoNNVaga
{
    //Dto de criacao de relacionamentos entre entrevistados e tecnologias
    public class CreateEntrevistadoNNTecnologiaDto : BaseCreatTecnologiaNNDto
    {
        public int EntrevistadoId { get; set; }
    }
}
