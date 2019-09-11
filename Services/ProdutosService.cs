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

        public Produtos FindById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Produtos> FindAll()
        {
            return _context.Products.ToList();
        }

        public void Insert(Produtos obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = _context.Products.Find(id);
            _context.Products.Remove(obj);
            _context.SaveChanges();
        }
    }
}