
namespace Aula10;

class Program{  
    static void Main(string[] args)
    {

        var restaurante = new Restaurante();

        // Produtos iniciais (cardápio)
        restaurante.CadastrarProduto(new Produto(1, "Hambúrguer Clássico", 18.90m));
        restaurante.CadastrarProduto(new Produto(2, "Cheeseburger", 21.50m));
        restaurante.CadastrarProduto(new Produto(3, "Batata Frita", 12.00m));
        restaurante.CadastrarProduto(new Produto(4, "Refrigerante", 7.00m));
        restaurante.CadastrarProduto(new Produto(5, "Milkshake", 14.90m));

        Console.WriteLine("======= Bem vindo ao Pônei Donald! =======\n");
        Console.WriteLine("Vamos fazer seu cadastro.\n");

        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.WriteLine("Telefone (identificador): ");
        string telefone = Console.ReadLine() ?? "";

        var usuario = new Usuario(nome, telefone);

        int proximoIdPedido = 1;

        while (true)
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1) Fazer novo pedido");
            Console.WriteLine("2) Ver pedidos anteriores");
            Console.WriteLine("3) Sair");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine() ?? "0");

            if (opcao == 1)
            {
                var pedido = new Pedido(proximoIdPedido++);

                while (true)
                {
                    restaurante.ProdutosDisponiveis();

                    Console.Write("Digite o ID do produto para adicionar: ");
                    int idProduto = int.Parse(Console.ReadLine() ?? "0");

                    var produto = restaurante.BuscarProdutoPorId(idProduto);
                    if (produto == null)
                    {
                        Console.WriteLine("Produto não encontrado. Tenta de novo.\n");
                        continue;
                    }

                    pedido.AdicionarProduto(produto);
                    Console.WriteLine($"Adicionado: {produto.Nome}\n");

                    Console.WriteLine("1) Adicionar mais um produto");
                    Console.WriteLine("2) Finalizar pedido");
                    Console.Write("Escolha: ");
                    int acao = int.Parse(Console.ReadLine() ?? "0");

                    if (acao == 2)
                    {
                                restaurante.AdicionarPedido(pedido);

                        bool finalizado = pedido.FinalizarPedido();
                        if (finalizado)
                        {
                            Console.WriteLine("\nSeu pedido estará pronto em breve!\n");
                        }
                        else
                        {
                            
                            Console.WriteLine("Pedido não finalizado.\n");
                        }
                        break;
                    }
                }
                            }
                            else if (opcao == 2)
                            {
                                usuario.VerPedidosAnteriores();
                                }
                                else if (opcao == 3)
                                {
                                    Console.WriteLine("\nValeu! Até a próxima");
                                    break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opção inválida.\n");
                                    }
        }
    }
}