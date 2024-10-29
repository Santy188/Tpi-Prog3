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
        [MaxLength(15), MinLength(3)]
        public string ProdName { get; set; }
        [MaxLength(50), MinLength(10)]
        public string ProdDescription { get; set; }
        [Range(0, 1000000)]
        public decimal ProdPrice { get; set; }
        [Range(0, 2500)]
        public int ProdStock { get; set; }
    }
}
