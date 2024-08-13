using Microsoft.AspNetCore.Mvc;
using ProniaMVC.Models;
using ProniaMVC.ViewModels;

namespace ProniaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slide> slide = new List<Slide>
            {
                new Slide{
                Id = 1,
                Title="First Title",
                SubTitle="First SubTitle",
                Description="Desc First",
                Order=1,
                Image="1-1.png"
                },
                new Slide{
                Id = 2,
                Title="Second Title",
                SubTitle="Second SubTitle",
                Description="Desc Second",
                Order=3,
                Image="1-1.png"
                },
                new Slide{
                Id = 3,
                Title="Third Title",
                SubTitle="Third SubTitle",
                Description="Desc Third",
                Order=2,
                Image="1-1.png"
                },
            };

            HomeVM homeVM = new HomeVM
            {
                Slides = slide.Take(2).OrderBy(s => s.Id).ToList(),
            };
            return View(homeVM);
        }
    }
}
