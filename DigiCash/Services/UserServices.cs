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
        public async Task<bool> CreateUser(String tc , String firstName , String lastName , String password)
        {
            User user = new User
            {
                firstName = firstName,
                lastName = lastName,
                password = password,
                tc = tc
            };
            AddUserToDb(user);
            return true;
        }
        public async Task<bool> AddUserToDb(User user)
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

        public async Task<IdentityUser> GetOneUser(string tc)
        {
            /*var user = await _userManager.FindByIdAsync(tc);
             if (user != null)
                 return user;
             throw new Exception("Kullanici bulunamadi.");*/

            //CS0029 Hatası var.
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> ResetPassword(User user)
        {
            await _userManager.RemovePasswordAsync(user);
            var result = await _userManager.AddPasswordAsync(user, user.password);
            return result;
        }
        public async Task<IdentityResult> DeleteOneUser(User user)
        {
            return await _userManager.DeleteAsync(user);
        }

    }
}

