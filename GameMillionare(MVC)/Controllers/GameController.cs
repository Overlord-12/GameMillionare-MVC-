using GameMillionare_MVC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace GameMillionare_MVC_.Controllers
{
    public class GameController : Controller
    {
        QuestionContext qc = new QuestionContext();
        // GET: Game
        public ActionResult Index()
         {
            //var quest = from data in db.Questions
            //            group data by data.Id;   
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            qc.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult ProcessGame(string startGame)
        {
            IEnumerable<Answer> ques = qc.Answers.Include(p => p.Question).Take(1);
            return View(ques);
        }

       
    }
 
}