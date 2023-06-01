using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using OnlineShopping2.Models;

namespace OnlineShopping2.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            //check if user is already logged in
            ClaimsPrincipal ClaimUser = HttpContext.User;
            if (ClaimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        public async Task <IActionResult >Login(USLogin modelLogin)
        {

            if(modelLogin.Email =="user@example.com" && 
                modelLogin.Password == "123"
                )

            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email) ,
                    new Claim("OtherProperties", "Example Rple")

                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                    );

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }

            if (modelLogin.Email == "admin@example.com" &&
               modelLogin.Password == "123"
               )

            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email) ,
                    new Claim("OtherProperties", "Example Rple")

                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                    );

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "AdminD");
            }


            if (modelLogin.Email == "employee@example.com" &&
             modelLogin.Password == "123"
             )

            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email) ,
                    new Claim("OtherProperties", "Example Rple")

                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                    );

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "SalesOrderAdmin");
            }




            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}
