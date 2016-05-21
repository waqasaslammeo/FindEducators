using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Log
    {


        public int Id { get; set; }

        public int  LogTypeId { get; set; }
        public virtual LogType LgType { get; set; }
        public string LogDetail { get; set; }

        public int UserId { get; set; }
        public virtual User Users { get; set; }
    }
}
