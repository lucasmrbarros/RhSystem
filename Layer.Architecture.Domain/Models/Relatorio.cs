using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Layer.Architecture.Domain.Models
{
    //Modelo do relatorio
    public class Relatorio
    {
        public string Vaga { get; set; }
        public string Tecnologia { get; set; }
        public int Pontos { get; set; }
        public string Entrevistado { get; set; }
    }
}
