using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Chat
    {


        public int Id { get; set; }

        public int CreateBy { get; set; }
        public virtual User Users { get; set; }



    }
}
