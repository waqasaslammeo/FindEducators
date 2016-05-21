using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class UserLocation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public int AreaId { get; set; }
        public virtual Area Areas { get; set; }

    }
}
