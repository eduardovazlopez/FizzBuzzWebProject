using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWebProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzWebProject.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet("/api/fizzbuzz")]
        public ActionResult<IList<string>> Get()
        {
            List<string> result = new List<string>();
            FizzBuzzService.ExecuteFizzBuzz(result);
            return Ok(result);
        }
    }
}