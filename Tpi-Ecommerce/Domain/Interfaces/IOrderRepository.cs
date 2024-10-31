using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order? GetOrderById(int id);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        bool DeleteOrder(int id);
        void SaveChanges();
    }
}
