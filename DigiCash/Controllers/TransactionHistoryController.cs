using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionHistoryController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> transactionHistory([FromBody] Money money)
        {
            return Ok();
        }
    }
}

