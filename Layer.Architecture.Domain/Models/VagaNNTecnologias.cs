﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Architecture.Domain.Models
{
    public class VagaNNTecnologias : BaseNNTecnolgias
    {
        public virtual Vaga Vaga { get; set; }
        public int VagaId { get; set; }
    }
}
