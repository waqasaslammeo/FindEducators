using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class UserAchievement
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public string Achievement { get; set; }
        public DateTime AchievementYear { get; set; }
        public string Link { get; set; }
    
    }
}
