using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMillionare_MVC_.Models
{
    public class Question
    {
        public string Text { get; set; }
        public int Id { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public Question(){
            Answers = new List<Answer>();
        }
    }
}