using System;
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
        MongoDbServices _m;

        public DepositMoneyController(DepositServices depositServices, MongoDbServices m) {
            _depositServices = depositServices;
            _m = m;
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
            if (request.Amount != null && request.WalletId != null)
            {
                response = await _depositServices.deposit(request.WalletId, request.Amount ?? 0);
            }
            else
            {
                return BadRequest("You didn't send an ID or an Amount value");
            }

            if (request.amount == null || request.walletId == null) { return BadRequest("You didn't send an ID or an Amount value");}

            bool response = await _depositServices.deposit(request.walletId, request.amount ?? 0);
            return Ok();
        }
    }
}

