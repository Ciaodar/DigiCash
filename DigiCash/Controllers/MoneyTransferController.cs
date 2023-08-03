using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoneyTransferController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> moneyTransfer([FromBody] Money money)
        {
            return Ok();
        }
    }
}

