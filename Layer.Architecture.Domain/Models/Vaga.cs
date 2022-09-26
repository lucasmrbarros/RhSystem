using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Layer.Architecture.Domain.Models
{
    public class Vaga : BaseModel
    {
        public int Salario { get; set; }

        [JsonIgnore]

        public virtual List<Entrevistado>Entrevistados { get; set; }

        [JsonIgnore]

        public virtual List<VagaNNTecnologias> Tecnologias{ get; set;}
    }
}
