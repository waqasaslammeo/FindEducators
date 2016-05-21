using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class UserLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Boolean IsActive { get; set; }   
    }
}
