﻿using AutoMapper;
using Layer.Architecture.Domain.Dtos.Vaga.VagaNNTecnologiaDto;
using Layer.Architecture.Infra.Data.Context;
using Microsoft.AspNetCore.Http;
using System.Collections;
using System.Linq;
using Layer.Architecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Layer.Architecture.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VagaNNTecnologiaController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public VagaNNTecnologiaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]

        public IActionResult AdicionaVagaTecnologia([FromForm] CreateVagaNNTecnologiaDto dto)
        {
            VagaNNTecnologias VagaTec = _mapper.Map<VagaNNTecnologias>(dto);
            _context.vagaNNTecnologias.Add(VagaTec);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RetornoVagaTecnologia), new { VagaTec.Id}, VagaTec);
        }

 
        [HttpGet]
        public IEnumerable RetornoVagaTecnologia()
        {
            return _context.vagaNNTecnologias.ToList();
        }

        [Route("{Idvaga}/{IdTec}")]
        [HttpPut]
        public ActionResult AdicionaPesos(int Idvaga, int IdTec, [FromForm] UpdateVagaNNTecnologiaDto dto)
        {
            VagaNNTecnologias vaga = _context.vagaNNTecnologias.Where(vaga => vaga.VagaId == Idvaga && vaga.TecId == IdTec).FirstOrDefault();

            if (vaga == null)
            {
                return NotFound();
            }

            _mapper.Map(dto, vaga);
            _context.SaveChanges();
            return NoContent();
        }
    }
}