using System;
using DigiCash.Models;
using DigiCash.Services.WalletServices;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoneyTransferController : Controller
    {
        TransferMoneyServices _transferMoney;

        public MoneyTransferController(TransferMoneyServices transferMoney) {
            _transferMoney = transferMoney;
        }

        [HttpPost]
        public async Task<IActionResult> moneyTransfer([FromBody] TransactionModel transaction)
        {
            try
            {
                bool response;
                if (transaction.amount != null && transaction.walletId != null&& transaction.targetWalletId != null)
                {
                    response = await _transferMoney.transferMoney(transaction.walletId,transaction.targetWalletId,transaction.amount ?? 0);
                }
                else
                {
                    return BadRequest("You didn't send an ID, TargetID or an Amount value");
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something Went Wrong.");
            }
            return Ok();
        }
    }
}

