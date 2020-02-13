using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQL_Test.Services;
using SQL_Test.Models;

namespace SQL_Test.Controllers
{
    public class TestQuery : ControllerBase
    {
        [HttpPost]
        [Route("v1/SQL/GetData")]
        public IActionResult Postgres()
        {
            using var db = new PersonContext();
            var persons = db.Person
            .Where(p => p.name == "Will")
            .ToList();

            return Ok(persons);
        }
    }
}