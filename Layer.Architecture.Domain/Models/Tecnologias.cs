namespace Layer.Architecture.Domain.Models
{
    public class Tecnologias : BaseModels
    {
        public string Nome { get; set; }
        //Entrevistados com conhecimento das tecnologias
        public virtual Entrevistado Entrevistado { get; set; }
        public int EntrevistadoId { get; set; }
        //Vagas com as tecnlogias requisitadas
        public virtual Vaga Vaga { get; set; }
        public int VagaId { get; set; }
    }
}
