using MVC_test.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace MVC_test.Data
{
    public class SeedingService
    {
        private BancotesteContext _context;

        public SeedingService(BancotesteContext c)
        {
            _context = c;
        }

        public void Seed()
        {
            if(_context.Products.Any() || _context.Armazems.Any())
            {
                return;
            }
            else // caso vazio
            {
                Armazem arm = new Armazem(DateTime.Now);
                arm.Lista = new List<Produtos>();
                arm.Lista.Add(new Produtos(01,"Água",Tipos.Comestível,1.50));
                arm.Lista.Add(new Produtos(02,"Pizza",Tipos.Comestível,29.99));
                arm.Lista.Add(new Produtos(03,"Arroz",Tipos.Comestível,5.50));
                arm.Lista.Add(new Produtos(04,"Refrigerante",Tipos.Comestível,4.50));

                arm.Lista.Add(new Produtos(05,"Computador",Tipos.Eletrônico,2850.00));
                arm.Lista.Add(new Produtos(06,"Smartphone",Tipos.Eletrônico,1099.00));

                _context.Armazems.Add(arm);

                _context.Products.AddRange(arm.Lista);

                _context.SaveChanges();

            }
        }

    }
}