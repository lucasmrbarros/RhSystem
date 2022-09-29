<<<<<<< Updated upstream
﻿
using Layer.Architecture.Domain.Models;
=======
﻿using System.ComponentModel.DataAnnotations;
>>>>>>> Stashed changes

namespace Layer.Architecture.Domain.Dtos.Entrevistado
{
    //Dto de criacao de usuarios
    public class CreateEntrevistadoDto : BaseCreateDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
<<<<<<< Updated upstream
        public int Pontos { get; set; }
=======
        [Required]
>>>>>>> Stashed changes
        public int VagaId { get; set; }
    }
}
