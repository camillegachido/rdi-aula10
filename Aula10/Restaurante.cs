    public class Restaurante
    {
        public List<Produto> Produtos { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Restaurante()
        {
            Produtos = new List<Produto>();
            Pedidos = new List<Pedido>();
        }
        public void CadastrarProduto(int id, string nome, double valor)
        {
            Produto produto = new Produto(id, nome, valor);
            Produtos.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso!\n");
        }
        public Produto? BuscarProdutoPorId(int id)
        {
            foreach (var produto in Produtos)
            {
                if (produto.Id == id)
                {
                    //Console.WriteLine($"Produto encontrado: {produto.Nome}\n");
                    return produto;
                }
            }
            Console.WriteLine("Produto com esse id não encontrado.\n");
            return null;
        }

        public void ListarProdutosDisponiveis()
        {
            Console.WriteLine("\n");
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Não há produtos disponíveis.\n");
                return;
            }
            Console.WriteLine("Produtos disponíveis:");

            foreach (var produto in Produtos)
            {
                Console.WriteLine($"Id: {produto.Id} | Nome: {produto.Nome}");
            }
            Console.WriteLine("\n");
        }
    }
