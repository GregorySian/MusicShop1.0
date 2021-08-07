using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Data;
using MusicHub.Interfaces;
using MusicHub.Models;
using MusicHub.ViewModels;

namespace MusicHub.Controllers
{
    public class ProductController : Controller
    {
        private IAlbumRepository _repository;
        private Genre genre;
        private readonly ApplicationDbContext _dbContext;
        public int PageSize = 6;

        public ProductController(IAlbumRepository repo)
        {
            _repository = repo;
        }

        public IActionResult SearchIndex(string searchString)
        {
         
            return View();
        }
      
      

        public IActionResult FilterByGenre(string genre, int productPage = 1)
           => View(new AlbumsListViewModel
           {
               Albums = _repository.Albums
                        .Where(a => genre == null || a.Genre == genre)
                        .OrderBy(a => a.Id)
                        .Skip((productPage - 1) * PageSize).Take(PageSize),

               PaginationInfo = new PaginationInfoViewModel
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   TotalItems = genre == null ?
                    _repository.Albums.Count() :
                    _repository.Albums.Where(e =>
                    e.Genre == genre).Count()
               },
               CurrentGenre = genre
           });

        public async Task<IActionResult> List(int pageNumber = 1)
        {
            return View(await PaginatedList<Album>.CreateAsync(_repository.Albums, pageNumber, 4));
        }



        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var album = _repository.Albums.Where(a => a.Id == id);

            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

       
    }

}
