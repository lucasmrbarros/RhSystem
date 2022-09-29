using Layer.Architecture.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Layer.Architecture.Domain.Dtos.Entrevistado
{
    //Dto de leitura de entrevistados 
    public class ReadEntrevistadoDto : BaseReadDto
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Pontos { get; set; }

        public Models.Vaga Vaga { get; set; }
    }
}
