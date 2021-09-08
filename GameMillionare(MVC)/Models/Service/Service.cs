using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameMillionare_MVC_.Models
{
    public class Service
    {
        static QuestionContext  qc = new QuestionContext();
        public static List<Answer> ques;
        public static List<Answer> Init(int val)
        {
            ques = qc.Answers.Include(p => p.Question).Take(val * 4).ToList();
            RandomList();
            var result = ques.Take(4).ToList();
            Remove(result);
            return result;
        }
        public static void Remove(List<Answer> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                ques.Remove(result[i]);
            }
        }
        public static List<Answer> NextQuest()
        {
            if (ques.Count == 0) return new List<Answer>();
            var result = ques.Take(4).ToList();
            Remove(result);
            return result;
        }
        public static void RandomList()
        {
            Random RND = new Random();
            //for (int i = 0; i < ques.Count; i++)
            //{
            //    var tmp = ques[0];
            //    ques.RemoveAt(0);
            //    ques.Insert(RND.Next(ques.Count), tmp);
            //}
        }

    }
}