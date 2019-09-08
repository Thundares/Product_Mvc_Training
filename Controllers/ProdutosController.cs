using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_test.Models;
using MVC_test.Services;

namespace MVC_test.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosService _ps;
         public ProdutosController(ProdutosService p)
        {
            _ps = p;
        }

        public IActionResult Index()
        {
            var list = _ps.FindAll();
            return View(list);
        }
    }
}