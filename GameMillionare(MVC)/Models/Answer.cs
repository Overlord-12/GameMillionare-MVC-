using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMillionare_MVC_.Models
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public byte Correct { get; set; }
        public int Id { get; set; }
        public int QuestionId { get; set; }
    }
}