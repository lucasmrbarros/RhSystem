using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Architecture.Domain.Models;

namespace Layer.Architecture.Domain.Models
{
    //Modelo de base 
    public class BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
