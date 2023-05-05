using Fuentes_SportsStore.Models;

namespace Fuentes_SportsStore.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}