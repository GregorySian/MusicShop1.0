using Microsoft.AspNetCore.Mvc;
using MusicHub.Interfaces;
using MusicHub.Models;
using System.Linq;

namespace MusicHub.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IAlbumRepository _repository;

        public NavigationMenuViewComponent(IAlbumRepository repository)
        {
            _repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["Genre"];
            return View(_repository.Albums
            .Select(x => x.Genre)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
