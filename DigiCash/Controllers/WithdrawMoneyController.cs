using DigiCash.Models;
using DigiCash.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithdrawMoneyController : Controller
    {
        private readonly BalanceServices _balanceServices;
        private readonly AmountServices _amountServices;
        private readonly ConfigSettings _configSettings;

        public WithdrawMoneyController(BalanceServices balanceServices, AmountServices amountServices, ConfigSettings configSettings)
        {
            _balanceServices = balanceServices;
            _amountServices = amountServices;
            _configSettings = configSettings;
        }

        [HttpPut]
        public IActionResult WithdrawMoney([FromBody] WithdrawRequest request)
        {
            // İlk olarak hesap bakiyesini kontrol edin
            double currentBalance = _balanceServices.GetBalance(request.WalletId);

            if (currentBalance < request.Amount)
            {
                return BadRequest("Hesap bakiyesi yetersiz.");
            }

            // Min-max çekim ayarlarını kontrol edin
            if (request.Amount >= _configSettings.MIN_WITHDRAW_VALUE && request.Amount <= _configSettings.MAX_WITHDRAW_VALUE)
            {
                // Para çekme işlemi için veritabanına istek atın
                bool withdrawalSuccessful = _amountServices.WithdrawMoney(request.WalletId, request.Amount);

                if (withdrawalSuccessful)
                {
                    // Bakiyeyi güncellemek için BalanceServices'ı kullanın
                    bool balanceUpdated = _balanceServices.UpdateBalance(request.WalletId, -request.Amount);

                    if (balanceUpdated)
                    {
                        return Ok("Para çekme işlemi başarılı.");
                    }
                    else
                    {
                        // Bakiye güncelleme başarısızsa, işlemi geri alın
                        _amountServices.DepositMoney(request.WalletId, request.Amount);
                        return BadRequest("Bakiye güncelleme hatası.");
                    }
                }
                else
                {
                    return BadRequest("Para çekme işlemi gerçekleştirilemedi.");
                }
            }

            return BadRequest("Çekilecek miktar sınırlar dışında.");
        }
    }
}
