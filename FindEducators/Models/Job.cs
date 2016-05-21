using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Job
    {

        public int Id { get; set; }

        public  string  JobTitle { get; set; }

        public int PostedBy  { get; set; }
        public virtual User Users { get; set; }

        public DateTime PostedDate { get; set; }


        public DateTime ExpiryDate { get; set; }

        public int JobTypeId { get; set; }
        public virtual JobType JobTypes { get; set; }

        public string Experience { get; set; }

        public string Location { get; set; }

        public DateTime Timing { get; set; }
    
    
    }
}
