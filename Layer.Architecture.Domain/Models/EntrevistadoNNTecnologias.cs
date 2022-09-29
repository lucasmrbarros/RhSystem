using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Models
{
    //Modelo do relacionamento entre entrevistados e tecnologias
    public class EntrevistadoNNTecnologias : BaseNNTecnolgias
    {
        public virtual Entrevistado Entrevistado { get; set; }
        public int EntrevistadoId { get; set; }
    }
}
