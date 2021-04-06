using Cadastros_WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastros_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new  Client
            {
                Id = 1,
                Date = DateTime.Now.AddDays(index),
                Name = "Batista"
            }).ToArray();
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return Ok("Batista");
        }

        

    }
}
