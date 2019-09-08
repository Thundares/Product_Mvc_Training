using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_test.Models;


namespace MVC_test.Controllers
{
    public class ProdutosController : Controller
    {
         public ProdutosController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}