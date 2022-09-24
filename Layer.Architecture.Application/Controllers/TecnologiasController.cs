using AutoMapper;
using Layer.Architecture.Domain.Dtos.Tecnologia;
using Layer.Architecture.Domain.Models;
using Layer.Architecture.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

namespace Layer.Architecture.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TecnologiasController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public TecnologiasController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarTecnologia([FromForm] CreateTecnologiaDto tecnologiaDto)
        {
            Tecnologias tecnologias = _mapper.Map<Tecnologias>(tecnologiaDto);
            _context.Add(tecnologias);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RetornaTecnologiasPorId), new { tecnologias.Id }, tecnologias);
        }

        [HttpGet("{id}")]
        public IActionResult RetornaTecnologiasPorId(int id)
        {
            Tecnologias tecnologias = _context.Tecnologias.FirstOrDefault(_context => _context.Id == id);

            if (tecnologias == null)
            {
                return NotFound();
            }
            ReadTecnologiaDto tecnologiaDto = _mapper.Map<ReadTecnologiaDto>(tecnologias);
            return Ok(tecnologiaDto);
        }


        [HttpGet]
        public IEnumerable RetornaTecnologias()
        {
            return _context.Tecnologias.ToList();
        }
    }

}
