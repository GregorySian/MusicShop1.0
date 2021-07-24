using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHub.ViewModels
{
    public class OrderItemViewModel
    {
        public int  ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Units { get; set; }
        public decimal Discount => 0;
        public string PictureUrl { get; set; }
    }
}
