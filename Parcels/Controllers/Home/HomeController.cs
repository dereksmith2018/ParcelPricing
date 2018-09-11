using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult HomePage()
    {
      List<Parcel> allParcel = new List<Parcel> {};
      return View();
    }
    [HttpPost("/home_page")]
    public ActionResult Receipt()
    {
      Parcel myParcel = new Parcel(int.Parse(Request.Form["length"]), int.Parse(Request.Form["width"]),int.Parse(Request.Form["height"]), int.Parse(Request.Form["weight"]));
    //  myParcel.Save() incase you need to save multiple entries on the screen
      List<Parcel> allParcel = Parcel.GetAll();
      return View("Receipt_Page", allParcel);
    }
  }
}
