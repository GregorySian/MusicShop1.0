using Microsoft.AspNetCore.Mvc;
using MusicHub.Models;

namespace MusicHub.Components
{
    public class WishlistSummaryViewComponent : ViewComponent
    {
        private Wishlist _wishlist;
        public WishlistSummaryViewComponent(Wishlist wishlist)
        {
            _wishlist = wishlist;
        }
        public IViewComponentResult Invoke()
        {
            return View(_wishlist);
        }
    }
}
