namespace MVC_test.Models
{
    public class Produtos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Tipos tipo { get; set; }
        public double preco { get; set; }

        public Produtos()
        {

        }

        public Produtos(int id, string n, Tipos t, double p)
        {
            this.id = id;
            nome = n;
            tipo = t;
            preco = p;
        }
    }
}