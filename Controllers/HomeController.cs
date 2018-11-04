using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LocalizationDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LocalizationDemo.Controllers
{

    public class PersonController : Controller
    {
        public IActionResult Edit()
        {
            var vm = new PersonViewModel()
            {
                Birthdate = DateTime.Now
            };
            return View(vm);
        }     
        
        [HttpPost]
        public IActionResult Edit(PersonViewModel vm)
        {
            if(!ModelState.IsValid)
                return View(vm);

            return View("Details", vm);
        }

    }
}
