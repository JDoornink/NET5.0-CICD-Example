using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CICD_Example.Controllers
{
    public class HealthController : Controller
    {
        /// <summary>
        /// Endpoint used for kubernetes health check
        /// </summary>
        /// <returns></returns>
        public IActionResult Alive() => Ok(string.Format("{0}:{1}", "Local DateTime", DateTime.Now));

    }
}
