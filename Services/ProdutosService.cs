using MVC_test.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_test.Services
{
    public class ProdutosService
    {
        private readonly BancotesteContext _context;
        public ProdutosService(BancotesteContext c)
        {
            _context = c;
        }

        public List<Produtos> FindAll()
        {
            return _context.Products.ToList();
        }
    }
}