using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Models
{
    public class BaseNNTecnolgias
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public virtual Tecnologias Tecnologias { get; set; }
        public int TecId { get; set; }
    }
}
