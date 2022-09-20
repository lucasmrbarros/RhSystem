using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Layer.Architecture.Domain.Models
{
    public class Empresa : BaseModels
    {
        public string RazaoSocial { get; set; }
        [JsonIgnore]
        public virtual List<Vaga> Vagas { get; set; }
    }
}
