using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class UserTest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public int TestId { get; set; }
        public virtual Test Tests { get; set; }
        public int ResultId { get; set; }
        public virtual TestResult Results { get; set; }
    }
}
