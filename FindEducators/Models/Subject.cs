using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int SubjectCategoryId { get; set; }
        public virtual SubjectCategory SubCategory { get; set; }
        
    }
}
