using Layer.Architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Dtos.EntrevistadoNNVaga
{
    //Dto de leitura do relacionamento entre entrevistados e tecnologias
    public class ReadEntrevistadoNNTecnologiaDto : BaseReadTecnologiaNNDto
    {
        public Models.Entrevistado Entrevistado { get; set; }
    }
}
