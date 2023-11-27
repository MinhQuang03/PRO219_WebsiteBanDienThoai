using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage="Không được để trống mục này!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Không được để trống mục này!")]
        public string Password { get; set; }
        public string? Name { get; set; }
        [Required(ErrorMessage = "Không được để trống mục này!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Không được để trống mục này!")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string? ImageUrl { get; set; }

        public int Status { get; set; }

        public int? Points { get; set; }

        public virtual Cart? Carts { get; set; }
    }
}
