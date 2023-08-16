using System;
using DigiCash.Models;
using Microsoft.AspNetCore.Identity;
namespace DigiCash.Services
{
    public class UserServices
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<UserServices> _logger;
        private readonly PostgreSqlServices _postgreSqlServices;
        public UserServices(SignInManager<User> signInManager , UserManager<User> userManager ,
            ILogger<UserServices> logger , PostgreSqlServices postgreSqlServices)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _postgreSqlServices = postgreSqlServices;
        }
        public async Task<User> CreateUser(String tc , String firstName , String lastName , String password)
        {
            User user = new User
            {
                firstName = firstName,
                lastName = lastName,
                password = password,
                tc = tc
            };
            return user;
        }
        public async Task<bool> addUserToDb(User user)
        {
            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                Console.WriteLine("oldum");
                return true;
            }else
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error);
                }
                return false;
            }
        }
    }//JWT Generatorler eklenicek
}

