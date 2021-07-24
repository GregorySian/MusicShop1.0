using System.Linq;

namespace MusicHub.Models.Order
{
    public interface IOrderRepository
    {
        IQueryable<Orders> Orders { get; }
        void SaveOrder(Orders order);

    }
}
