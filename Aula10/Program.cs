using Aula10.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Pônei Donald!");
        Console.WriteLine("Faça seu cadastro para iniciar o seu pedido.");

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu telefone: ");
        string telefone = Console.ReadLine();

        Usuario usuario = new Usuario(nome, telefone);

        Restaurante restaurante = new Restaurante();
        restaurante.CadastrarProduto(new Produto(1, "Hamburguer", 25));
        restaurante.CadastrarProduto(new Produto(2, "Batata frita", 15));
        restaurante.CadastrarProduto(new Produto(3, "Refrigerante", 5));

        bool continuarSistema = true;

        while (continuarSistema)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Fazer novo pedido");
            Console.WriteLine("2 - Ver pedidos anteriores");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Pedido pedido = new Pedido(usuario);
                    bool finalizarPedido = false;

                    while (!finalizarPedido)
                    {
                        Console.WriteLine("\n--- CARDÁPIO ---");
                        restaurante.ListarProdutosDisponiveis();

                        Console.Write("Escolha o ID do produto: ");
                        int idProduto = int.Parse(Console.ReadLine());

                        Produto produtoEscolhido = restaurante.BuscarProdutoPorId(idProduto);

                        if (produtoEscolhido != null)
                        {
                            pedido.AdicionarProduto(produtoEscolhido);
                            Console.WriteLine("Produto adicionado ao pedido!");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }

                        Console.WriteLine("\n1 - Adicionar outro produto");
                        Console.WriteLine("2 - Finalizar pedido");
                        Console.Write("Escolha uma opção: ");

                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 2)
                        {
                            finalizarPedido = true;
                        }
                    }

                    usuario.FazerPedido(restaurante, pedido);

                    Console.WriteLine("\n--- RESUMO DO PEDIDO ---");
                    pedido.FinalizarPedido();
                    Console.WriteLine("Seu pedido estará pronto em breve!");
                    break;

                case 2:
                    Console.WriteLine("\n--- PEDIDOS ANTERIORES ---");
                    usuario.VerPedidosAnteriores();
                    break;

                case 3:
                    continuarSistema = false;
                    Console.WriteLine("Obrigado pela preferência!");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
