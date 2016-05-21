using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Feedback
    {

        public int Id { get; set; }


        public int PostedById { get; set; }
        public virtual User Users1 { get; set; }
        public int PostedToId { get; set; }
        public virtual User Users2 { get; set; }
        public string Message { get; set; }
        public DateTime PostedDate { get; set; }
        public int FeedbackTypeId { get; set; }
        public virtual FeedbackType FdbkType { get; set; }

    }
}