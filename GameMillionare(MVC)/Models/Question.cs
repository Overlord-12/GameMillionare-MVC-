using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMillionare_MVC_.Models
{
    public class Question
    {
        public string QuestionText { get; set; }
        public int Id { get; set; }

        public IEnumerable<Answer> Answers { get; set; }
    }
}