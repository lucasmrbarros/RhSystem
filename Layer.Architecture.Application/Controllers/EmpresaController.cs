using AutoMapper;
using Layer.Architecture.Domain.Dtos.Empresa;
using Layer.Architecture.Domain.Models;
using Layer.Architecture.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Layer.Architecture.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EmpresaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarEmpresa([FromBody] CreateEmpresaDto empresaDto)
        {
            Empresa empresa = _mapper.Map<Empresa>(empresaDto);
            _context.Add(empresa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaEmpresaPorId), new { Id = empresa.Id }, empresa);
        }

        [HttpGet]
        public IEnumerable<Empresa> RecuperaEmpresas([FromQuery] string RazaoSocial)
        {
            return _context.Empresas.ToList();
        }

        [HttpGet("{id}")]

        public IActionResult RecuperaEmpresaPorId(int id)
        {
            Empresa empresa = _context.Empresas.FirstOrDefault((_context => _context.Id == id));
            if (empresa == null)
            {
                return NotFound();
            }
            
            ReadEmpresaDto empresaDto = _mapper.Map<ReadEmpresaDto>(empresa);
            return Ok(empresaDto);
        }
 
    }


}
