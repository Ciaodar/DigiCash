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
            double balance;
            try
            {
                if (request.walletId != null)
                {
                    balance = await _balanceServices.getBalanceAsync(request.walletId);
                }
                else
                {
                    return BadRequest("You didn't send walletId!");
                }
                return Ok(balance);
            }catch(Exception) {
                return StatusCode(500, "Something was gone wrong!");
            }
        }
    }
}
