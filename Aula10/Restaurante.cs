namespace Aula10;
public class Restaurante
{
       public List<Produto> Produtos { get; set; } = new List<Produto>();
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();


    public void CadastrarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public Produto BuscarProdutoPorId(int id)
    {
        foreach (var produto in Produtos)
        {
            if (produto.Id == id)
            {
                Console.WriteLine($"Produto encontrado: {produto.Nome}, Valor: R$ {produto.Valor}");
                return produto;
            }
        }
        Console.WriteLine("Produto não encontrado."); return null;
    }

    public void ProdutosDisponiveis()
    {
        Console.WriteLine("=== Produtos Disponíveis ===");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Valor: R$ {produto.Valor}");
        }
    }

    internal void AdicionarPedido(Pedido pedido)
    {
        Pedidos.AddRange();
    }
}


