using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEducators.Models
{
    public class ChatMessage
    {


        public int Id { get; set; }

        public int  SenderId { get; set; }
        public virtual User Users1 { get; set; }
        public  int RecieverId { get; set; }
        public virtual User Users2 { get; set; }
        public string  Message { get; set; }

        public DateTime PostedDate { get; set; }

        public string PostedTime { get; set; }


        public int  ChatId { get; set; }
        public virtual Chat Cht { get; set; }
    }
}
