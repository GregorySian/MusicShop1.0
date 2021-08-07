using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicHub.Models;
using MusicHub.Interfaces;
using MusicHub.ViewModels;
using System.Linq;

namespace MusicHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly ILogger<HomeController> _logger;
        public int PageSize = 3;
  
        public HomeController(ILogger<HomeController> logger, IAlbumRepository albumRepository)
        {
            _logger = logger;
            _albumRepository = albumRepository;
        }
        [HttpGet]
        public ActionResult Index(string searchString)
        {

            var albums = _albumRepository.Albums;

            if (!string.IsNullOrEmpty(searchString))
            {
                albums = _albumRepository.Albums.Where(a => a.Title.Contains(searchString));
                return RedirectToAction("Result", "Index");
            }
            else
            {
                return View(albums);
            }

          
        }


        public IActionResult Privacy()
        {
            return View();
        }

        
        public ActionResult Result(string Album)
        {
            ViewBag.Message = Album;
            return View();
        }

        public async Task<IActionResult> List(int pageNumber = 1)
        {
            return View(await PaginatedList<Album>.CreateAsync(_albumRepository.Albums, pageNumber, 3));
        }
    }
}

    
