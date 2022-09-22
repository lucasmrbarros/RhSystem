using AutoMapper;
using Layer.Architecture.Domain.Dtos.Vaga;
using Layer.Architecture.Domain.Models;
using Layer.Architecture.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

namespace Layer.Architecture.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VagaController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public VagaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaVaga([FromForm] CreateVagaDto vagaDto)
        {
            Vaga vaga = _mapper.Map<Vaga>(vagaDto);
            _context.vagas.Add(vaga);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaVagaPorId), new { vaga.Id }, vaga);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaVagaPorId(int id)
        {
            Vaga vaga = _context.vagas.First(_context => _context.Id == id);

            if (vaga == null)
            {
                return NotFound();
            }
            ReadVagaDto vagaDto = _mapper.Map<ReadVagaDto>(vaga);
            return Ok(vagaDto);
        }

        [HttpGet]

        public IEnumerable RetornaVagas()
        {
            return _context.vagas.ToList();
        }

    }
}
