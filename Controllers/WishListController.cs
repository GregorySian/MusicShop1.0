using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Interfaces;
using MusicHub.Models;
using MusicHub.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using MusicHub.Services;
using Microsoft.AspNetCore.Authorization;

namespace MusicHub.Controllers
{
    [Authorize]
    public class WishListController : Controller
    {
        private IAlbumRepository _albumRepository;
        private Wishlist _wishlist;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WishListController(IAlbumRepository albumRepository, Wishlist wishlistService, IHttpContextAccessor httpContextAccessor)
        {
            _albumRepository = albumRepository;
            _wishlist = wishlistService;
            _httpContextAccessor = httpContextAccessor;
        }
        public ViewResult Index(string returnUrl)
        {

            return View(new WishlistIndexViewModel
            {
                Wishlist = _wishlist,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToWishList(int Id, string returnUrl, String wishlistId, CookieOptions cookieId)
        {
            Album album = _albumRepository.Albums.FirstOrDefault(a => a.Id == Id);
            if (album != null)
            {
                
                _wishlist.AddItems(album, wishlistId);
               
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromWishlist(int albumId, string returnUrl)
        {
            Album album = _albumRepository.Albums.FirstOrDefault(a => a.Id == albumId);
            if (album != null)
            {
                _wishlist.RemoveLine(album);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
