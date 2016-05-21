using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class TestResult
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public virtual Test test { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public string Result { get; set; }
        public string Distinction { get; set; }

    }
}
