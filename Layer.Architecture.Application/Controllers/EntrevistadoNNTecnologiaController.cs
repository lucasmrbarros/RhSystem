using AutoMapper;
using Layer.Architecture.Domain.Dtos.EntrevistadoNNVaga;
using Layer.Architecture.Domain.Models;
using Layer.Architecture.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;
using System.Collections;
using System.Linq;


//Controladora responsavel pelas as operacoes relaciondas ao relacionamentos entre os candidatos e as entrevistas
namespace Layer.Architecture.Application.Controllers
{ 
    [ApiController]
    [Route ("[controller]")]
    public class EntrevistadoNNTecnologiaController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EntrevistadoNNTecnologiaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]

        public IActionResult AdiconaEntrevistadoVaga([FromForm] CreateEntrevistadoNNTecnologiaDto dto)
        {
            EntrevistadoNNTecnologias EntTec = _mapper.Map<EntrevistadoNNTecnologias>(dto);
            _context.Add(EntTec);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RetornarEntrevistadoVaga), new { EntTec.Id }, EntTec);
        }

        [HttpGet]

        public IEnumerable RetornarEntrevistadoVaga()
        {
            return _context.entrevistadoNNTecnologias.ToList();
        }
    }
}
