using SIMPLE_MEMBER_PROVIDER.Models;
using SIMPLE_MEMBER_PROVIDER.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace SIMPLE_MEMBER_PROVIDER.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                bool isAuthentic = WebSecurity.Login(user.Username, user.Password, user.RememberMe);

                if (isAuthentic)
                {
                    string returnUrl = Request.QueryString["ReturnUrl"];
                    if (returnUrl == null)
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        return Redirect(Url.Content(returnUrl));
                    }
                }
                else
                {
                    ModelState.AddModelError("Password", "Username / Password is not correct!");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Login", "Account");
        }
        [HttpGet, Authorize(Roles = "Administrator , Manager")]
        public ActionResult Register()
        {
            bool isAuthentic = Roles.IsUserInRole(WebSecurity.CurrentUserName, "Administrator");
            if (isAuthentic)
                ViewBag.RoleId = 1;
            else
                ViewBag.RoleId = 0;
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken, Authorize(Roles = "Administrator , Manager")]
        public ActionResult Register(Register register)
        {
            bool isAuthentic = Roles.IsUserInRole(WebSecurity.CurrentUserName, "Administrator");
            if (isAuthentic)
                ViewBag.RoleId = 1;
            else
                ViewBag.RoleId = 0;

            if (ModelState.IsValid)
            {
                bool userExist = WebSecurity.UserExists(register.UserName);
                if (userExist)
                {
                    ModelState.AddModelError("UserName", "User name is already exists");
                }
                else
                {
                    WebSecurity.CreateUserAndAccount(register.UserName, register.Password, new { FullName = register.FullName, Email = register.Email });
                    Roles.AddUserToRole(register.UserName, register.RoleName);
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            return View();
        }
        [HttpGet, Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Authorize]
        public ActionResult ChangePassword(ChangePassword change)
        {
            WebSecurity.ChangePassword(WebSecurity.CurrentUserName, change.OldPassword, change.NewPassword);
            return View();
        }

        [HttpGet, Authorize]
        public ActionResult UserProfile()
        {
            UserProfile profile = AccountVM.GetProfile(WebSecurity.CurrentUserId);
            return View(profile);
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public ActionResult UserProfile(UserProfile profile)
        {
            if (ModelState.IsValid)
            {
                AccountVM.UpdateProfile(profile);
                ViewBag.Message = "User ia Saved Successfully";
            }
                return RedirectToAction("Index", "Dashboard");
            
            //return View();
        }
        [HttpGet , Authorize]
        public ActionResult GetUserList()
        {
            List<UserLists> model = AccountVM.GetUserLists();
            return View(model);
        }
    }
}
