using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Models
{
    public class OrderDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public bool State { get; set; } = true;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public List<int> Products { get; set; }
        [Required]
        public string UserName { get; set; }

        public static OrderDTO ToDTO(Order entity)
        {
            OrderDTO dto = new OrderDTO();
            dto.Id = entity.Id;
            dto.State = entity.OrderState;
            dto.Price = entity.OrderPrice;
            dto.UserName = entity.ClientUser.Name;
            dto.Products = entity.Products.Select(p => p.Id).ToList(); 
            return dto;
        }
        public static List<OrderDTO> ToDTO(List<Order> entities) 
        {
            List<OrderDTO> listOrderDTO = new List<OrderDTO>();
            foreach (var item in entities) 
            {
                listOrderDTO.Add(ToDTO(item));
            }
            return listOrderDTO;
        }
        public static OrderDTO ToUpdateDTO(Order entity)
        {
            OrderDTO dto = new OrderDTO();
            dto.Id = entity.Id;
            dto.State = entity.OrderState;
            dto.Price = entity.OrderPrice;
            return dto;
        }
       
    }
}
