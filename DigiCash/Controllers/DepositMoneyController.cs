﻿using System;
using System.Net;
using DigiCash.Models;
using DigiCash.Services;
using DigiCash.Services.WalletServices;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepositMoneyController : Controller
    {
        DepositServices _depositServices;

        public DepositMoneyController(DepositServices depositServices) {
            _depositServices = depositServices;
        }

        [HttpPost]
        public async Task<IActionResult> DepositMoney([FromBody] RequestModel request) {
            //try
            //{
            //    bool response;
            //    if (request.amount!=null && request.walletId!=null)
            //    {
            //        response = await _depositServices.deposit(request.walletId, request.amount??0);
            //    }
            //    else
            //    {
            //        return BadRequest("You didn't send an ID or an Amount value");
            //    }
            //    return Ok();
            //}
            //catch (Exception e)
            //{
            //    return BadRequest();
            //}
            bool response;
            if (request.amount != null && request.walletId != null)
            {
                response = await _depositServices.deposit(request.walletId, request.amount ?? 0);
            }
            else
            {
                return BadRequest("You didn't send an ID or an Amount value");
            }
            return Ok();
        }
    }
}

