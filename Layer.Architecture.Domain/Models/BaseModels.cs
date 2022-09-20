using System.ComponentModel.DataAnnotations;

namespace Layer.Architecture.Domain.Models
{
    public class BaseModels
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }
    }
}
