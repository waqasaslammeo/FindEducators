using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace FindEducators.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
       [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string CNIC { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        public string Password { get; set; }
        [Required]
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        [Required]
        public string Address { get; set; }

       
        public int UserTypeId { get; set; }
        public virtual UserType Usertype { get; set; }

       
    }
}
