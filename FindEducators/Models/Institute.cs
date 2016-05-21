using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Institute
    {


        public int Id { get; set; }

        public string InstituteName { get; set; }
        public int CityId { get; set; }
        public virtual City Cities { get; set; }

    }
}
