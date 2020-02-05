using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LiveCodingFinal.Controllers
{
    public class TrickOrTreatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult(double trickers, string weather, int temp)
        {
            if (weather == "Clear")
                trickers = trickers * 1.10;
            else if (weather == "Cloudy")
                trickers = trickers * 1;
            else if (weather == "Raining")
                trickers = trickers * .75;
            else if (weather == "Full Moon")
                trickers = trickers * 1.25;

            if (temp == 40)
                trickers = trickers * .95;
            else if (temp == 50)
                trickers = trickers * 1;
            else if (temp == 60)
                trickers = trickers * 1.05;
            else if (temp == 70)
                trickers = trickers * 1.20;

            double candy = 0;
            
            candy = trickers * 3;

            return candy;
                
                
    }
}