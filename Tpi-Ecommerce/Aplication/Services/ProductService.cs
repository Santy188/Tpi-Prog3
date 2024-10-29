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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<ProductDTO> GetAll() { return ProductDTO.ToDTO(_repository.GetAll()); }

        public ProductDTO? GetProductByName(string name) 
        {
            var prod = _repository.GetByName(name);
           
            if (prod != null)
            {
                return ProductDTO.ToDTO(prod);
            }
            else { return null; }
        }

        public void AddProduct(AddProductRequest product)
        {
            var newProd = new Product()
            {
                ProductName = product.ProdName,
                ProductDescription =  product.ProdDescription,
                ProductPrice = product.ProdPrice,
                ProductStock = product.ProdStock,
            };
            _repository.AddProduct(newProd);
            _repository.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {

        }
        public void DeleteProduct(Product Product) 
        { 

        }
    }
}
