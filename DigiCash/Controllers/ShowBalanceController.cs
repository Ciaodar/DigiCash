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
        public IActionResult ShowBalance([FromBody] User user)
        {
            //  Kullanıcının hesap bakiyesini alın
            double balance = _balanceServices.GetBalance(user.WalletId); // Bu satırda WalletId'nin gerçek adını kullanmalısınız.

            //  Elde edilen bakiyeyi döndürün
            return Ok(balance);
        }
    }
}
