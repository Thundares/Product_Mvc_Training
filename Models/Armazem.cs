using System.Collections.Generic;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MVC_test.Models
{
    public class Armazem
    {
        
        public List<Produtos> Lista { get; set; }
        [Key] public DateTime Data { get; set; }

        public Armazem()
        {
            Lista = new List<Produtos>();
        }

        public Armazem(DateTime d) : this()
        {
            Data = d;
        }

        public double DiferencaDeValor(Armazem outro)
        {
            return (Lista.Sum(total => total.Preco) - outro.Lista.Sum(t => t.Preco));
        }

    }
}