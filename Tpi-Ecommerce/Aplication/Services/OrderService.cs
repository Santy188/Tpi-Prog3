using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetAll() {  return _orderRepository.GetAll(); }
        public Order GetOrderById(int id)
        {
            return _orderRepository.GetOrderById(id);
        }
        public void CreateOrder(Order order) { }
        public void UpdateOrder(Order order) { }
        public void DeleteOrder(int id) { }

    }
}
