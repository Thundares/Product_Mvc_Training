namespace MVC_test.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Tipos Tipo { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {

        }

        public Produtos(int id, string n, Tipos t, double p)
        {
            Id = id;
            Nome = n;
            Tipo = t;
            Preco = p;
        }
    }
}