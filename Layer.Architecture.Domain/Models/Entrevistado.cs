using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Models
{
    public class Entrevistado : BaseModel 
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Pontos { get; set; }

        public virtual Vaga Vaga{ get; set; }
        public int VagaId { get; set; }

        [JsonIgnore]
        public virtual List<EntrevistadoNNTecnologias> Tecnologias { get; set; }
    }
}
