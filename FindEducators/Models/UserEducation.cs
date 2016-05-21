using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class UserEducation
    {
        public int Id { get; set; }
        public int UserId  { get; set; }
        public virtual User Users { get; set; }
        public int DegreeId { get; set; }
        public virtual Degree Deg { get; set; }
        public int InstituteId { get; set; }
        public virtual Institute Insti { get; set; }
        public string PassingYear { get; set; }
        public string CGPA { get; set; }
        public string Percentage { get; set; }
        public string Grade { get; set; }
        
        
    }
}
