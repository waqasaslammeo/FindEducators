using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class SubjectTest
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public virtual Test Tst { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subj { get; set; }
    }

}
