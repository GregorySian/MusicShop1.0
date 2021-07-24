using System;
using System.Collections.Generic;
using MusicHub.Models.Order;

namespace MusicHub.ViewModels
{
    public class OrderViewModel
    {
        public const string DEFAULT_STATUS = "pending";

        public int OrderNumber { get; set; }
        public DateTimeOffset OrderDate{ get; set; }
        public decimal Total { get; set; }
        public string Status => DEFAULT_STATUS; 
        public Orders ShippingAddress { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; }
    }
}
