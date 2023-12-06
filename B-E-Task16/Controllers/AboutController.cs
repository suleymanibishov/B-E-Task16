using B_E_Task16.Models;
using B_E_Task16.ViewModels.About;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B_E_Task16.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            AboutIndexViweModel viweModel = new AboutIndexViweModel
            {
                Cards = new List<Card>()
                {
                    new Card
                    {
                        Icon = "display-4 bx bxs-bulb text-light",
                        Title = "Our Vision",
                        Description = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."
                    },
                     new Card
                    {
                        Icon = "display-4 bx bx-revision text-light",
                        Title = "Our Mission",
                        Description = "Eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam quis."
                    }, new Card
                    {
                        Icon = "display-4 bx bxs-select-multiple text-light",
                        Title = "Our Goal",
                        Description = " Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor."
                    }
                }
                
            };
            return View(viweModel);
        }
    }
}
