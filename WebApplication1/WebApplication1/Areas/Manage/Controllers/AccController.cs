using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Areas.Manage.Controllers
{
    [Area("Manage")]
    
    public class AccController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccController(UserManager<AppUser> userManager , SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        { 
            return View();
        
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Error");
                return View();
            
            }
            AppUser appUser = await _userManager.FindByNameAsync(loginVM.Username);
            if(appUser == null)
            {
                ModelState.AddModelError("", "Error");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password , false , false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Error");
                return View();
            }

            return RedirectToAction("index", "account");
            
                


         

        }

        //public async Task< IActionResult> CreateAdmin()
        //{
        //    AppUser appUser = new AppUser
        //    {
        //        Fullname = "Cavad Allahverdiyev",
        //        UserName = "SuperAdmin"
        //    };
              
        //    var result =await _userManager.CreateAsync(appUser , "Admin123");

        //    return Ok(result);

            
        //}


    }
}
