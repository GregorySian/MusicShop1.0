using Microsoft.AspNetCore.Mvc;
using MusicHub.Models.Order;
using MusicHub.Models.Cart;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace MusicHub.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderRepository repository;
        private readonly Cart cart; 

        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        [Authorize]
        public ViewResult List()
            => View(repository.Orders.Where(o => !o.Shipped));


    [HttpPost]
    [Authorize]
    public IActionResult MarkShipped(int OrderId)
        {
            Orders order = repository.Orders.FirstOrDefault(o => o.OrdersId == OrderId);
            if (order != null)
            {
                order.Shipped = true;
                repository.SaveOrder(order);
            }
            return RedirectToAction(nameof(List));
        }


       public ViewResult Checkout() => View(new Orders());

        [HttpPost]
        public IActionResult Checkout(Orders order)
        {
            if(cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                order.Status = "pending";
                order.OrderDate = System.DateTime.UtcNow;
                repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }
        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}