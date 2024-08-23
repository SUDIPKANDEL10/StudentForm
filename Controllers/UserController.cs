using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentForm.Models;
using StudentForm.ViewModels;

namespace StudentForm.Controllers
{
    public class UserController : Controller
    {

        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
           
        public UserController(SignInManager<AppUser> signInManager,UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName!, model.Password!, model.RememberMe, false);

                if (result.Succeeded)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid Login");
                return View(model);
            }
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Register(RegisterVM model)

        {
            if (ModelState.IsValid)
            {
                AppUser user = new()
                {
                    Name = model.Name,
                    UserName = model.Email,
                    Email = model.Email,
                    Address = model.Address,
                };
                var result = await userManager.CreateAsync(user, model.Password!);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "User");
        }
    }
}
