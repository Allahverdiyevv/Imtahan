using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    

    public class HomeController : Controller
    {
		private readonly DataContext _dataContext;

		public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;

		}
        public IActionResult Index()
        {
            List<AppBay> appBays =_dataContext.AppBays.ToList();
            return View(appBays);
        }

       
    }
}