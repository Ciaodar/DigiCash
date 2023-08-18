using System;
using DigiCash.Models;
using DigiCash.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowBalanceController : Controller
    {
        private readonly BalanceServices _balanceServices;

        public ShowBalanceController(BalanceServices balanceServices)
        {
            _balanceServices = balanceServices;
        }

        [HttpGet]
        public async Task<IActionResult> ShowBalance([FromBody] RequestModel request)
        { 
            if (request.walletId == null) { return BadRequest("WalletId gönderilmedi"); }

            double balance = await _balanceServices.GetBalanceAsync(request.walletId);
            return Ok(balance);
        }

    }
}
