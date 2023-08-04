using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionHistoryController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> transactionHistory([FromBody] Wallet wallet)
        {
            return Ok();
        }
    }
}

