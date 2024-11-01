using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Models.Request
{
    public class AuthenticateRequest
    {
        [MinLength(3), MaxLength(20)]
        public string Name { get; set; }
        [MinLength(5), MaxLength(16)]
        public string Password { get; set; }
        [Range(0, 1)]
        public UserType UserType { get; set; }

    }
}
