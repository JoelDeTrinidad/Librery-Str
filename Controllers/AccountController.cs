using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Librery_Str.Helper.Interfaces;
using Librery_Str.Helpers;
using Librery_Str.Models;

namespace Librery_Str.Controllers
{
    public class AccountController : Controller
    {

        private readonly LibreryStrContext _context;

        public AccountController(LibreryStrContext context)
        {
            _context = context;
        }
        //Get Account
        public IActionResult Index()
        {
            return View();
        }


         // GET: Auth/Auth
        public IActionResult Auth()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Auth(Account account)
        {
              string encryptedPassword = EncryptionHelper.SHA1HashStringForUTF8String(account.Password);
             var currentUser =  _context.Users.Where(x => x.User == account.User && x.Password == encryptedPassword).FirstOrDefault();
            if (currentUser == null){
                account.LoginErrorMessage = "Usuario o contraseña  incorrecta.";
                return View("Index", account);
            } else{
                //HttpContext.Session.SetInt32["Id"] = currentUser.Id;
                HttpContext.Session.SetInt32("UserId", currentUser.Id);
                HttpContext.Session.SetString("UserName", currentUser.User);
                return RedirectToAction("Index", "Home"); 
            }
            
        }
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Account");
        }

    }
}
