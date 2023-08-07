using System;
using DigiCash.Models;
using DigiCash.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoneyTransferController : Controller
    {
        WalletServices _walletServices;

        public MoneyTransferController(WalletServices walletServices) {
            Console.WriteLine("hello");
            _walletServices = walletServices;
        }
        [HttpPost]
        public async Task<IActionResult> moneyTransfer([FromBody] Wallet wallet)
        {
            return Ok();
        }
    }
}

