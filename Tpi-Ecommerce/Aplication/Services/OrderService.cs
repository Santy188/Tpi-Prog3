using Aplication.Interfaces;
using Aplication.Models;
using Aplication.Models.Request;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        public OrderService(IOrderRepository orderRepository, IUserRepository userRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _productRepository = productRepository;
        }
        public List<OrderDTO> GetAll() 
        { 
            var orders =  _orderRepository.GetAll();
            foreach(var item in orders)
            {
                item.OrderPrice = item.Products.Sum(p=> p.ProductPrice);
            }
            return OrderDTO.ToDTO(orders);
        }
        public OrderDTO? GetOrderById(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if(order == null) { return null; }

            order.OrderPrice = order.Products.Sum(p=> p.ProductPrice);

            if(order != null) { return OrderDTO.ToDTO(order); }

            return null;
        }
        public bool CreateOrder(AddOrderRequest orders) 
        {
            var products = _productRepository.GetProductsById(orders.ProductsId);
            var user = _userRepository.GetByName(orders.Username);
            if (products.Count == 0) { return false; }
            var obj = new Order()
            {
                OrderState = orders.OrderState,
                ClientUser = user,
                Products = products.ToList(),
            };
            _orderRepository.CreateOrder(obj);
            _orderRepository.SaveChanges();
            return true;
        }
        public bool UpdateOrder(UpdateOrderRequest order) 
        {
            var products = _productRepository.GetProductsById(order.ProductsId);
            var orderEntity = _orderRepository.GetOrderById(order.Id);
            if(orderEntity == null) { return false; }
            if(products.Count == 0) { return false; }

            orderEntity.OrderState = order.OrderState;
            orderEntity.Products = products.ToList();

            _orderRepository.UpdateOrder(orderEntity);
            _orderRepository.SaveChanges();
            return true;
        }
        public bool DeleteOrder(int id) 
        {
            return _orderRepository.DeleteOrder(id);
        }
    }
}
