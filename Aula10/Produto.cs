
namespace Aula10
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Valor { get; set; }

        public Produto(int id, string nome, decimal valor)
            {
                Id = id;
                Nome = nome;
                Valor = valor;
            }

    }
}