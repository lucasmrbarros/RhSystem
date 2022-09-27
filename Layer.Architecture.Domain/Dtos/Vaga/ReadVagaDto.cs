
namespace Layer.Architecture.Domain.Dtos.Vaga
{
    public class ReadVagaDto : BaseReadDto
    {
        public int Salario { get; set; }

        public object Entrevistados { get; set; }

        public Models.Tecnologias Tecnologias{ get; set; }
    }
}
