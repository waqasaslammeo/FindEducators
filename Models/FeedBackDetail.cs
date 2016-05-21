using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class FeedbackDetail
    {


        public int Id { get; set; }
        public int FeedbackId  { get; set; }
        public virtual Feedback Fdbk { get; set; }
        public int Punctual { get; set; }

        public int Behavior { get; set; }
        public int Personality { get; set; }

        public int Knowledge { get; set; }

        public int Overall  { get; set; }

    }


}
