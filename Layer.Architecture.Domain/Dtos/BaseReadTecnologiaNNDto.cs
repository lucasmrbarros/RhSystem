using Layer.Architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dto base para leitura de relacionametos com tecnologias

namespace Layer.Architecture.Domain.Dtos
{
    public class BaseReadTecnologiaNNDto
    {
        public int Id { get; set; }
        public Tecnologias Tecnologias  { get; set; }
    }
}
