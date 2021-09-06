using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMillionare_MVC_.Models
{
    public class Answer
    {
        public string Text { get; set; }
        public byte Correct { get; set; }
        public int Id { get; set; }
        public int Question_id { get; set; }
        public Question Question { get; set; }

    }
}