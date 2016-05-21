using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public int TestLevelId { get; set; }
        public virtual TestLevel TstLvl { get; set; }
        public int TestTypeId { get; set; }
        public virtual TestType Testtype { get; set; }
       

    }
}
