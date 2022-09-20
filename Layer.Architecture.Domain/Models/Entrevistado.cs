using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Models
{
    public class Entrevistado : BaseModels
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Pontos { get; set; }
        [JsonIgnore]
        public virtual List<Tecnologias> Tecnologias { get; set; }
        [JsonIgnore]
        public virtual List<Vaga> Vagas { get; set; }
    }
}
