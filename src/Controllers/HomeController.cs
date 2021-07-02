using CICD_Example.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CICD_Example.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalculationModel model)
        {
            if (model.calculationMethod.ToString() == "add")
            {
                model.Result = model.FirstNumber + model.SecondNumber;
            }
            if (model.calculationMethod.ToString() == "subtract")
            {
                model.Result = model.FirstNumber - model.SecondNumber;
            }
            if (model.calculationMethod.ToString() == "multiply")
            {
                model.Result = model.FirstNumber * model.SecondNumber;
            }
            if (model.calculationMethod.ToString() == "divide")
            {
                model.Result = model.FirstNumber / model.SecondNumber;
            }
            return View(model);
        }
    }
}
