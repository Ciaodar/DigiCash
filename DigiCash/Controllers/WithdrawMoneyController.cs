﻿using DigiCash.Models;
using DigiCash.Services.WalletServices;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithdrawMoneyController : Controller
    {
        WithdrawServices _withdrawServices;
        public WithdrawMoneyController(WithdrawServices withdrawServices)
        {
            _withdrawServices = withdrawServices;
        }

        [HttpPut]
        public async Task<IActionResult> WithdrawMoney([FromBody] TransactionModel transaction)
        {
            try
            {
                bool response;
                if (transaction.amount != null && transaction.walletId != null)
                {
                    response = await _withdrawServices.withdraw(transaction.walletId, transaction.amount ?? 0);
                }
                else
                {
                    return BadRequest("You didn't send an ID or an Amount value");
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something Went Wrong.");
            }
        }
    }
}
