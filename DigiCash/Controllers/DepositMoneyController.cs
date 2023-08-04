using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepositMoneyController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> depositMoney([FromBody] Wallet wallet) {
            
            return Ok();
        }
    }
}

