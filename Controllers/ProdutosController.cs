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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produtos obj)
        {
            _ps.Insert(obj);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? a)
        {
            if(a == null)
            {
                return NotFound();
            }

            var obj = _ps.FindById(a.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [
            HttpPost
        ]
        [ValidateAntiForgeryTokenAttribute]
        public IActionResult Delete(int Id)
        {
            _ps.Remove(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}