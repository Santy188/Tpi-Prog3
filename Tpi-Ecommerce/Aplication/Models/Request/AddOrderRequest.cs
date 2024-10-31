using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Models.Request
{
    public class AddOrderRequest
    {
        [Required]
        public bool OrderState { get; set; } = false;
        public IList<int> ProductsId { get; set; }
        [Required]
        [MinLength(3), MaxLength(15)]
        public string Username { get; set; }

    }
}
