namespace Aula10
{
    public class Restaurante
    {
        public List<Produto> Produtos { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Restaurante()
        {
            Produtos = new List<Produto>();
            Pedidos = new List<Pedido>();
        }
        public void CadastrarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }
        public void BuscarProdutoPorId(int id)
        {
            foreach (var produto in Produtos)
            {
                if (produto.Id == id)
                {
                    Console.WriteLine($"Produto encontrado: {produto.Nome}");
                    return;
                }
            }
            Console.WriteLine("Produto com esse id não encontrado.");
        }

        public void ListarProdutosDisponiveis()
        {
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Não há produtos disponíveis.");
                return;
            }
            Console.WriteLine("Produtos disponíveis:");

            foreach (var produto in Produtos)
            {
                Console.WriteLine($"Id: {produto.Id} | Nome: {produto.Nome}");
            }
        }
    }
}
