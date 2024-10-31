using Aplication.Models;
using Aplication.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IProductService
    {
        List<ProductDTO> GetAll();
        ProductDTO? GetProductByName(string productName);
        
        void AddProduct(AddProductRequest request);

        void UpdateProduct(string name, UpdateProductRequest product);

        bool DeleteProduct(string name);

        void SaveChanges();

    }
}
