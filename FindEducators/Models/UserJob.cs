using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class UserJob
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public virtual Job Jobs { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public DateTime ApplyDate { get; set; }
        public int AreaId { get; set; }
        public virtual Area Areas { get; set; }

    }
}
