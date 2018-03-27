using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Voorbeeld4_MVC.Controllers
{
    public class WerknemerController : Controller
    {
        // GET: Werknemer
        
        public ActionResult Index()
        {
            return View();
        }

        [NonAction]
        public void Boe()
        {

        }

       
        public ActionResult VerdubbelWeddes()
        {
            //return View();
            return Redirect("~/Werknemer/WeddesAangepast");
            //var viewResult = new ViewResult();
            //return viewResult; //return geeft als waarde bijhorend
            //cshtml bestand in bijhorende map van de controller
            //ContentResult: return bevat platte tekst, pure tekst
            //FileResult: return geeft binaire data van een bestand op de
            //server.
            //return File(@"e:\test\land.jpg","image/jpg")
            //Jsonresult {bloemen ["naam"=>"aster", "naam"=>"roos"]}
            //RedirectResult.
           

        }
        public ActionResult WeddesAangepast()
        {
            return View();
        }

        public ActionResult Read(int? id)
        {
            return View();
        }

        public ActionResult ShowAll(int? paginaNr)
        {
            return View();
        }
    }
}