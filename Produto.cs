namespace FastFoodProject.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int QtdEstoque { get; set; }

        public Produto(int id, string nome, double valor, int qtdEstoque)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            QtdEstoque = qtdEstoque;
        }
    }
}