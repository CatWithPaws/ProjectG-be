using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestServer.Auth
{
    [ApiController]
    [Route("api/1.0/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IResult Login(){
           return null;
        }
    }
}