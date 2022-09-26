namespace Layer.Architecture.Domain.Dtos.Vaga
{
    public class CreateVagaDto : BaseCreateDto
    {
        public int Salario { get; set; }
        public int TecId { get; set; }
    }
}

