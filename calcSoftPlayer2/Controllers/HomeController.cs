using calcSoftPlayer2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calcSoftPlayer2.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }


    public ActionResult ShowMeTheCode()
    {
      return View();
    }

    // GET: CalculaJuros
    public ActionResult CalculaJuros(decimal? valorInicial, int? tempo, decimal? casasDecimais)
    {
      return View();
    }

  }
}