
using System.ComponentModel.DataAnnotations;

namespace Layer.Architecture.Domain.Dtos.Vaga
{
    //Dto de leitrua de vagas cadastradas
    public class ReadVagaDto : BaseReadDto
    {
        [Required]
        public int Salario { get; set; }

        public object Entrevistados { get; set; }
    }
}
