using DigiCash.Models;
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
        public async Task<IActionResult> WithdrawMoney([FromBody] RequestModel request)
        {
            if (request.amount == null || request.walletId == null) { return BadRequest("You didn't send an ID or an Amount value"); }

            bool response = await _withdrawServices.withdraw(request.walletId, request.amount ?? 0);
            return Ok(response);
        }
    }
}
