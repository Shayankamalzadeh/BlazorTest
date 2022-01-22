using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Shared.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Caption { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }

}
