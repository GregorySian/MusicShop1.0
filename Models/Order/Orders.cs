using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static MusicHub.Models.Cart.Cart;

namespace MusicHub.Models.Order
{
    public class Orders
    {
        [BindNever]
        public int OrdersId { get; set; }
       
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        public string ShippingAddress { get; set; }
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Please enter your City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your Country")]
        public string Country { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public bool Shipped { get; set; }

        public bool GiftWrap { get; set; }

    }
}
