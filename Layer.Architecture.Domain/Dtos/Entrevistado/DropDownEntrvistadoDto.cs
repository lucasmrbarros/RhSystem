using Layer.Architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Dtos.Entrevistado
{
    internal class DropDownEntrvistadoDto
    {
        public List <Models.Entrevistado> Entrevistados { get; set; }
    }
}
