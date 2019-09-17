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

        public async Task<IActionResult> Index()
        {
            var list = await _ps.FindAllAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produtos obj)
        {
            await _ps.InsertAsync(obj);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? a)
        {
            if(a == null)
            {
                return NotFound();
            }

            var obj = await _ps.FindByIdAsync(a.Value);
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
        public async Task<IActionResult> Delete(int Id)
        {
            await _ps.RemoveAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}