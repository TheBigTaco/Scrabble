using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/result")]
      public ActionResult Result()
      {
        try
        {
          int score = Game.WordScore(Request.Form["user-input"]);
          return View(score);
        }
        catch(Exception)
        {
          return View(null);
        }
      }
    }
}
