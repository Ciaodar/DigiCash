using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowBalanceController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> showBalance([FromBody] User user)
        {

            
            return Ok();
        }
    }
}

