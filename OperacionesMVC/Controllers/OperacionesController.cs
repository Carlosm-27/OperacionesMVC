using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperacionesMVC.Models;

namespace OperacionesMVC.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {

            Datos objModelo = new Datos();
            objModelo.variableA = 3;
            objModelo.variableB = 5;
            objModelo.resultado = objModelo.variableA + objModelo.variableB;
            ViewData["Resultado"] = objModelo.resultado;
            return View();
        }

        public ActionResult Resta()
        {

            Datos objModelo = new Datos();

            try
            {
                objModelo.variableA = Convert.ToDouble(Request.Form["txtvalor1"].ToString());
                objModelo.variableB = Convert.ToDouble(Request.Form["txtvalor2"].ToString());
                objModelo.resultado = objModelo.variableA - objModelo.variableB;
            }
            catch{ 
            
            }
            return View("Resta", objModelo);
        }


        public ActionResult Division()
        {

            Datos objModelo = new Datos();
            objModelo.variableA = 100;
            objModelo.variableB = 80;
            objModelo.resultado = objModelo.variableA / objModelo.variableB;
            ViewData["Resultado"] = objModelo.resultado;
            return View();
        }


        public ActionResult Multiplicacion()
        {

            Datos objModelo = new Datos();

            try
            {
                objModelo.variableA = Convert.ToDouble(Request.Form["txtvalor1"].ToString());
                objModelo.variableB = Convert.ToDouble(Request.Form["txtvalor2"].ToString());
                objModelo.resultado = objModelo.variableA * objModelo.variableB;
            }
            catch
            {

            }
            return View("Multiplicacion", objModelo);
        }
    }
}