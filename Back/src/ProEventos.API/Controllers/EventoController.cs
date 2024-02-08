﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {


        public EventoController()
        {

        }

        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                 EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Rio grande do sul",
                Lote = "1 lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageUrl = "foto.png"
                },
                new Evento() {
                 EventoId = 2,
                Tema = "Angular 11 e suas novidades",
                Local = "São paulo",
                Lote = "3 lote",
                QtdPessoas = 650,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageUrl = "foto.png"
                }

            };


        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;


        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);


        }
    }
}
