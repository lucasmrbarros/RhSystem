using Layer.Architecture.Application.Models;
using Layer.Architecture.Domain.Models;
using Layer.Architecture.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Architecture.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Entrevista()
        {
            return View();
        }

        public IActionResult Pesos()
        {
            return View();
        }

        public IActionResult Ranking()
        {
            //Consulta Sql que gera o relatório rankeando os candidatos

            List<Relatorio> relatorio = new List<Relatorio>();


            using (MySqlConnection con = new MySqlConnection("server=localhost;database=Rhdb;user=root;password=root"))
            {
                string query = "SELECT VG.nome AS vaga, TEC.nome AS tecnologia, SUM(VNT.Pontos) AS Pontos, E.nome AS entrevistado FROM vaganntecnologias  AS VNT INNER JOIN vagas AS VG on vg.id = VNT.VagaId INNER JOIN tecnologias AS TEC ON TEC.Id = VNT.TecId INNER JOIN entrevistadonntecnologias AS ENT ON ENT.TecId = VNT.TecId INNER JOIN entrevistados AS E on E.id = ENT.EntrevistadoId group by entrevistado order by vaga, Pontos DESC;";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            relatorio.Add(new Relatorio
                            {
                                Vaga = Convert.ToString(sdr["Vaga"]),
                                Tecnologia = Convert.ToString(sdr["Vaga"]),
                                Pontos = Convert.ToInt32(sdr["Pontos"]),
                                Entrevistado = Convert.ToString(sdr["Entrevistado"]),
                            }); 
                        }
                    }
                    con.Close();
                }
            }

            return View(relatorio);
        }
        public IActionResult Vagas()
        {
            return View();
        }
        public IActionResult Candidatos()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        public IActionResult Error()
        {

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
    }
}
