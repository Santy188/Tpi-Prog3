using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Models.Request
{
    public class AddProductRequest
    {
        [MaxLength(30), MinLength(3)]
        public string ProdName { get; set; }
        [MaxLength(100), MinLength(10)]
        public string ProdDescription { get; set; }
        [Range(0, 10000000)]
        public decimal ProdPrice { get; set; }
        [Range(0, 10000)]
        public int ProdStock { get; set; }
    }
}
