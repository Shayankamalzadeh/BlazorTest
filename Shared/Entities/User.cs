using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Please write right format")]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Please write password")]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}
