using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithdrawMoneyController : Controller
    {
        [HttpPut]
        public async Task<IActionResult> WithdrawMoney([FromBody] Wallet wallet)
        {
            return Ok();
        }
    }
}

