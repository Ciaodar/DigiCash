using System;
using DigiCash.Models;
using DigiCash.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepositMoneyController : Controller
    {
        WalletServices _walletServices;

        public DepositMoneyController(WalletServices walletServices) {
            _walletServices = walletServices;
        }

        [HttpPost]
        public async Task<IActionResult> depositMoney([FromBody] Wallet wallet) {
            
            return Ok();
        }
    }
}

