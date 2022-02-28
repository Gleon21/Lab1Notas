using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1Notas.Controllers
{
    public class NotaController : Controller
    {
        public IActionResult Index(string Alumno, Double Datal1, Double Datap1,Double Datal2,Double Datap2,Double Datal3,Double Datap3  )
        {   //Segun yo asi va XD
            Double NotaFinal = (((Datal1 * 0.4) + (Datap1 * 0.6))/3) + (((Datal2 * 0.4) + (Datap2 * 0.6))/3) + (((Datal3 * 0.4) + (Datap3 * 0.6))/3);
            ViewBag.l1 = Datal1;
            ViewBag.p1 = Datap1;
            ViewBag.l2 = Datal2;
            ViewBag.p2 = Datap2;
            ViewBag.l3 = Datal3;
            ViewBag.p3 = Datap3;    
            ViewBag.NotaFinal = NotaFinal;
            ViewBag.Alumno = Alumno;
            return View();
        }

       

    }
}
