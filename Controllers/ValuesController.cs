using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EchoService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        // GET api/echo/hello
        [HttpGet("{message}")]
        public ActionResult<string> Get(string message)
        {
            return message;
        }
    }
}
