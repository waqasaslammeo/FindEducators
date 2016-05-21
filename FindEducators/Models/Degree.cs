using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Degree
    {

        public int Id { get; set; }

        public string DegreeName { get; set; }


        public int DegreeTypeId { get; set; }
        public virtual DegreeType DgType { get; set; }
        public string DegreeAbbrivation { get; set; }

       
    }
}
