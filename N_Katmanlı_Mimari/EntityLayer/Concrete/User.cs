using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class User : IEntity
    {
        [Required]
        public int UserId { get; set; } 
        public string? FullName { get; set; }
        public string? Email { get; set; } 
        public string? Password { get; set; } 
    }
}
