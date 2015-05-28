using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace PortFolio.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult SingleImage()
        {
            ViewBag.Image = "/Content/Images/Image1.bmp";

            return View();
        }

        public ActionResult ImageList()
        {
            string[] fileNames = Directory.GetFiles(@"\\abdfs01\ab\l\laab\visual studio 2013\Projects\PortFolio\PortFolio\Content\Images\");//.Except("*.");

            ViewBag.FN = fileNames;

            ViewBag.ImageRP = "/Content/Images/";
            
            return View();
        }
    }
}