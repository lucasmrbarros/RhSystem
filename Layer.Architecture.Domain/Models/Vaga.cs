using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Layer.Architecture.Domain.Models
{
    public class Vaga : BaseModels
    {
        public string Nome { get; set; }
        public virtual Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
        public virtual Entrevistado Entrevistado { get; set; }
        public int EntrevistadoId { get; set; }
        public int Salario { get; set; }
        [JsonIgnore]
        public virtual List<Tecnologias> Tecnologias { get; set; }
    }
}
