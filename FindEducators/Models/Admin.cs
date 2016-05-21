﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class Admin
    {
        [Key]
        public int Id{ get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Boolean IsActive { get; set; }
    }
}
