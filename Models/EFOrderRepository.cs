using Microsoft.EntityFrameworkCore;
using MusicHub.Data;
using MusicHub.Models.Order;
using System.Linq;

namespace MusicHub.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext _dbContext;

        public EFOrderRepository(ApplicationDbContext ctx)
        {
            _dbContext = ctx;
        }

        public IQueryable<Orders> Orders => _dbContext.Orders.Include(o => o.Lines).ThenInclude(l => l.Album);


        public void SaveOrder(Orders order)
        {
            _dbContext.AttachRange(order.Lines.Select(l => l.Album));
            if ( order.OrdersId == 0)
            {
                _dbContext.Orders.Add(order);
            }
            _dbContext.SaveChanges();
        }


    }
}
