using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Layer.Architecture.Domain.Models
{
    public class Tecnologias :BaseModel
    {
        [JsonIgnore]

        public virtual List<VagaNNTecnologias>vagas{ get; set; }
        public virtual List<EntrevistadoNNTecnologias> entrevistados { get; set; }
    }
}
