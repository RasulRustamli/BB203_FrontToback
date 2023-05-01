
using A_Word.DAL;
using A_Word.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace A_Word.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
       public IActionResult Index()
        {
            //Service service = new Service()
            //{
            //    ImgUrl = "img-1.png",
            //    Title = "Var"
          
            //};

            //_appDbContext.Services.Add(service);
            //_appDbContext.SaveChanges();

            return View(_appDbContext.Services.ToList());
        }
    }
}