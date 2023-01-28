using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Areas.Manage.Controllers
{
    [Area("Manage")]
	[Authorize]
	public class AppBayController : Controller
    {
        private readonly DataContext _dataContext;

        public AppBayController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            List<AppBay> bay = _dataContext.AppBays.ToList();
            return View(bay);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AppBay model)
        {
            if(model== null) return NotFound();

            _dataContext.AppBays.Add(model);
            _dataContext.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            AppBay bay = _dataContext.AppBays.Find(id);
            if(bay==null) return NotFound();


            return View();

        }

        [HttpPost]
        public IActionResult Update(AppBay appBay)
        {
            if(appBay==null) return NotFound();

            AppBay appex = _dataContext.AppBays.Find(appBay.Id);

            if(appex == null) return View();
            appex.Title1 = appBay.Title1;
            appex.Desc = appBay.Desc;


            _dataContext.Update(appex);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        
        }
        public IActionResult Delete(int id)        
        {
            AppBay APPBAYY =  _dataContext.AppBays.FirstOrDefault(c => c.Id == id);
            if(APPBAYY == null) return NotFound();

            _dataContext.Remove(APPBAYY);
            _dataContext.SaveChanges();
            return RedirectToAction("index");
        
        }
    }
}
