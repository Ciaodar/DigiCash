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
        public async Task<IActionResult> DepositMoney([FromBody] TransactionModel transaction) {
            try
            {
                bool response;
                if (transaction.amount!=null && transaction.walletId!=null)
                {
                    response = await _walletServices.deposit(transaction.walletId, transaction.amount??0); 
                }
                else
                {
                    return BadRequest("You didn't send an ID or an Amount value");
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(500,"Something Went Wrong.");
            }
        }
    }
}

