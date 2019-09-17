using MVC_test.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_test.Services
{
    public class ProdutosService
    {
        private readonly BancotesteContext _context;
        public ProdutosService(BancotesteContext c)
        {
            _context = c;
        }

        public async Task<Produtos> FindByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Produtos>> FindAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task InsertAsync(Produtos obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var obj = _context.Products.Find(id);
            _context.Products.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}