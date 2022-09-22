namespace Layer.Architecture.Domain.Dtos.Entrevistado
{
    public class CreateEntrevistadoDto : BaseCreateDto
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int VagaId { get; set; }
    }
}
