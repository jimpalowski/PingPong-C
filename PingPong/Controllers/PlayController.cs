using System;
using System.Collections.Generic;
using PingPong;
using Microsoft.AspNetCore.Mvc;

namespace PingPong.Controllers
{

  public class PlayController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
