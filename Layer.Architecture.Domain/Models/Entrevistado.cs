using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Models
{
    //Modelo de candidato
    public class Entrevistado : BaseModel 
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
<<<<<<< Updated upstream
        
        public int Pontos { get; set; }
=======
>>>>>>> Stashed changes

        [Required]
        public int VagaId { get; set; }
        [ForeignKey("VagaId")]
        public virtual Vaga Vaga { get; set; }


    }
}
