using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using bogoodski2020backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bogoodski2020backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CredentialController : ControllerBase
    {        
        private readonly ILogger<CredentialController> _logger;

        public CredentialController(ILogger<CredentialController> logger)
        {
            _logger = logger;
        }


        Credential secret = new Credential
        {
            Id = 0,
            UserName = "steve",
            PassWord = "1234"
        };

        [HttpPost]
        public IActionResult Post([FromBody] Credential credential)
        {

            if (credential.UserName == secret.UserName && credential.PassWord == secret.PassWord)
            {
                string message = "Success!";
                return Ok(message);
            }

            if(credential.UserName == secret.UserName && credential.PassWord != secret.PassWord) 
            {
                string message = "Wrong password";
                return Ok(message);
            }

            if(credential.PassWord == secret.PassWord && credential.UserName != secret.UserName) 
            {
                string message = "Wrong username";
                return Ok(message);
            }

            else 
            {
                return NoContent();
            } 

              
                
        }
    }
}