using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myWebProject.Models;
namespace myWebProject.Controllers
{
    public class MemoryController : Controller
    {
        public IActionResult Pepi(int total)
        {
            var list = new List<int>();

            for (int i = 0; i < total; i++)
            {
                list.Add(i + 1);
            }

            return View(list);
        }
    }
}
