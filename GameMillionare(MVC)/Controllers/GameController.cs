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

        public ActionResult EndGame()
        {
            return View("Index");
        }
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
                check = 100;
                ViewBag.HelpInfo = 0;
                ViewBag.Score = check;
                return View(Service.Init(Convert.ToInt32(startGame)));
            }
            else
            {
                var c = Service.NextQuest();
                if (c.Count == 0)
                {
                    return View("EndGame");
                }

                if (startGame == "false")
                {
                    ViewBag.HelpInfo = 1;
                    ViewBag.Score = check;
                    
                    return View(c);
                }
                if(startGame == "true")
                {
                    ViewBag.HelpInfo = 1;
                    check += 100;
                    ViewBag.Score = check;
                    return View(c);
                }
                if (startGame == "1")
                {
                    check += 100;
                    ViewBag.Score = check;
                    return View(c);
                }
                else
                {
                    ViewBag.Score = check;
                    return View(c);
                }
               
            }

        }

        
    }

}