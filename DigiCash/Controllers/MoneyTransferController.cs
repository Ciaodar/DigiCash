﻿using System;
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
        public async Task<IActionResult> moneyTransfer([FromBody] RequestModel request)
        {
            if (request.amount == null || request.walletId == null || request.targetWalletId == null) { return BadRequest("You didn't send an ID, TargetID or an Amount value");}

            bool response = await _transferMoney.transferMoney(request.walletId,request.targetWalletId,request.amount ?? 0);
            return Ok(response);
        }
    }
}

