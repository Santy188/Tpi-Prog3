using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Order> GetAll() 
        {
            return _context.Orders.Include(o => o.ClientUser).Include(o=> o.Products).ToList();
        }
        public Order? GetOrderById(int id) 
        {
            return _context.Orders.Include(o=> o.ClientUser).Include(o=> o.Products).FirstOrDefault(o=> o.Id == id);
        }
        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public bool DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
