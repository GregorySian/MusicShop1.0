using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MusicHub.ViewModels;

namespace MusicHub.Models.Order
{
    public class GetOrderDetails: IRequest<OrderViewModel>
    {
        public string UserName { get; set; }
        public int OrderId { get; set; }

        public GetOrderDetails(string userName, int orderId)
        {
            UserName = userName;
            OrderId = orderId;
        }
    }
}
