using System;
using DigiCash.Models;
using DigiCash.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionHistoryController : Controller
    {

        private readonly TransactionService _transactionService;
        public TransactionHistoryController(TransactionService transactionService) 
        {
            _transactionService = transactionService;
        }   
        [HttpGet]
        public async Task<IActionResult> transactionHistory([FromBody] ProcessHistory walletId)
        {
            try
            {
                var histories = walletId.histories;
                return Ok(histories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

