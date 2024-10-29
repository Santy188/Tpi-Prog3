using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Models
{
    public class ProductDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }

        public static ProductDTO ToDTO(Product entity)
        {
            ProductDTO dto = new ProductDTO();
            dto.Id = entity.Id;
            dto.Name = entity.ProductName;
            dto.Description = entity.ProductDescription;
            dto.Price = entity.ProductPrice;
            dto.Stock = entity.ProductStock;
            return dto;
        }

        public static List<ProductDTO> ToDTO(List<Product> entities)
        {
            List<ProductDTO> listProductDTO = new List<ProductDTO>();

            foreach (var item in entities)
            {
                listProductDTO.Add(ToDTO(item));
            }

            return listProductDTO;

        }
        public static ProductDTO ToUpdateDTO(Product entity)
        {
            ProductDTO dto = new ProductDTO();
            dto.Id = entity.Id;
            dto.Name = entity.ProductName;
            dto.Description = entity.ProductDescription;
            dto.Price = entity.ProductPrice;
            dto.Stock = entity.ProductStock;
            return dto;

        }

    }
}
