using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Models;
using MusicHub.Models.Cart;
using MusicHub.ViewModels;
using MusicHub.Interfaces;

namespace MusicHub.Controllers
{
    public class CartController : Controller
    {
        private IAlbumRepository _albumRepository;
        private Cart _cart;
        public CartController(IAlbumRepository albumRepository, Cart cartService)
        {
            _albumRepository = albumRepository;
            _cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = _cart,
                ReturnUrl = returnUrl
            });
        }


        public RedirectToActionResult AddToCart(int Id, string returnUrl)
        {
            Album album = _albumRepository.Albums.FirstOrDefault(a => a.Id == Id);

            if (album != null)
            {
                _cart.AddItems(album, 1);
            }

            return RedirectToAction("Index",new { returnUrl });
        }
       
        public RedirectToActionResult RemoveFromCart(int albumId, string returnUrl)
        {
            Album album = _albumRepository.Albums.FirstOrDefault(a => a.Id == albumId);

            if (album != null)
            {
                _cart.RemoveLine(album);
            }

            return RedirectToAction("Index", new{ returnUrl});
        }
    }
}