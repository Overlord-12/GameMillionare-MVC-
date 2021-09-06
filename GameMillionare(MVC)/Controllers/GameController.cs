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
        // GET: Game
        public static int check = 100;
        public static int HelpButton = 0;
        public ActionResult Index()
        {
            //var quest = from data in db.Questions
            //            group data by data.Id;   
            return View();
        }
        [HttpGet]
        public ActionResult ProcessGame(string startGame)
        {
            ViewBag.Score = check;
            ViewBag.HelpInfo = HelpButton;
            if(startGame == "checked")
            {
                ViewBag.HelpInfo = 1;
            }
            if (startGame == "10" || startGame == "15")
            {
                ViewBag.HelpInfo = 0;
                ViewBag.Score = 100;
                return View(Repository.Init());
            }
            else
            {
                if (startGame == "1")
                {
                    check += 100;
                    ViewBag.Score = check;
                    return View(Repository.NextQuest());
                }
                else
                {
                    ViewBag.Score = check;
                    return View(Repository.NextQuest());
                }
               
            }

        }
        public void GetData()
        {
            check = 1;
            ViewBag.Score = check;

        }


    }

}