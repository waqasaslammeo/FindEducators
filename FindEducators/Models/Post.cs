using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Post
    {
        public int Id  { get; set; }
        public string PostTitle { get; set; }
        public DateTime PostDate { get; set; }
        public int PostedBy { get; set; }
        public int PostTypeId { get; set; }
        public virtual PostType PstType { get; set; }

    } 


}
