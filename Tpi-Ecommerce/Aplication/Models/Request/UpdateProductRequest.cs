using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Models.Request
{
    public class UpdateProductRequest
    {
        [Required]
        [MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        [Required]
        [Range(0, 10000000)]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Stock {  get; set; }
        [Required]
        public bool State {  get; set; } = false;
    }
}
