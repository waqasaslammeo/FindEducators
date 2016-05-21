using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class PostDetail
    {


        public int Id { get; set; }

        public int PostId { get; set; }
        public virtual Post Pst { get; set; }
        public string PostBody { get; set; }
        
        public string FeaturedImage{ get; set; }  
    }
}
