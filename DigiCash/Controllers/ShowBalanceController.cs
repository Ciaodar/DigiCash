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

        [HttpPost]
        public async Task<IActionResult> ShowBalance([FromBody] TransactionModel transaction)
        {
            try
            {
                if (transaction.walletId != null)
                {
                    double balance = await _balanceServices.getBalanceAsync(transaction.walletId);

                }
                else
                {
                    return BadRequest("You didn't send walletId!");
                }
                return Ok();
            }catch(Exception) {
                return StatusCode(500, "Something was gone wrong!");
            }
        }
    }
}
