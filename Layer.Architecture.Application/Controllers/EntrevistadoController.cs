using AutoMapper;
using Layer.Architecture.Domain.Dtos.Entrevistado;
using Layer.Architecture.Domain.Models;
using Layer.Architecture.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

namespace Layer.Architecture.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntrevistadoController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EntrevistadoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarEntrevistado([FromForm] CreateEntrevistadoDto entrevistadoDto)
        {
            Entrevistado entrevistado = _mapper.Map<Entrevistado>(entrevistadoDto);
            _context.Entrevistados.Add(entrevistado);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaEntrevistadoPorId), new { Id = entrevistado.Id }, entrevistado);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEntrevistadoPorId(int id)
        { 
            Entrevistado entrevistado = _context.Entrevistados.FirstOrDefault(_context => _context.Id == id);

            if (entrevistado == null)
            {
                return NotFound();
            }
            ReadEntrevistadoDto entrevistadoDto = _mapper.Map<ReadEntrevistadoDto>(entrevistado);
            return Ok(entrevistadoDto);
        }


        [HttpGet]
        public IEnumerable RetornarEntrevistados([FromQuery] string nome)
        {
            return _context.Entrevistados.ToList();
        }
        
    }
}
