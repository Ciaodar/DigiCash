using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithdrawMoneyController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> withdrawMoney([FromBody] Wallet wallet)
        {
            
            return Ok();
        }
    }
}

