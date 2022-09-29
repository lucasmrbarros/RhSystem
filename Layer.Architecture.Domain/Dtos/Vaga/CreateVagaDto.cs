using System.ComponentModel.DataAnnotations;

namespace Layer.Architecture.Domain.Dtos.Vaga
{
    //Dto de criacao de vagas
    public class CreateVagaDto : BaseCreateDto
    {
        [Required]
        public int Salario { get; set; }
    }
}

