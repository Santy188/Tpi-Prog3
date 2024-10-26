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
    }
}
