using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dto base para leitura

namespace Layer.Architecture.Domain.Dtos
{
    public class BaseReadDto
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
    }
}
