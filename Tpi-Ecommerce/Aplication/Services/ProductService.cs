using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<Product> GetAll(){ return _repository.GetAll(); }

        public Product GetById(int id){ return _repository.GetById(id); }
        public Product GetByName(string name) { return _repository.GetByName(name);}

        public void AddProduct(Product product)
        {

        }
        public void UpdateProduct(Product product)
        {

        }
        public void DeleteProduct(Product Product) 
        { 

        }
    }
}
