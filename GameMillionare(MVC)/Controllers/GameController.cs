using GameMillionare_MVC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameMillionare_MVC_.Controllers
{
    public class GameController : Controller
    {
        QuestionContext db = new QuestionContext();
        // GET: Game
        public ActionResult Index()
         {
            //var quest = from data in db.Questions
            //            group data by data.Id;   
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult ProcessGame(string startGame)
        {
            IEnumerable<Question> li = db.Questions;
            return View(li);
        }
    }
 
}