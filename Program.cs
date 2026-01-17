using System; 
// Importa funcionalidades básicas do C# (Console, DateTime, etc)

class Program
{
    static void Main()
    {
        Restaurante restaurante = new Restaurante();
        
        // CADASTRO DOS PRODUTOS

        restaurante.CadastrarProduto(new Produto(1, "Hambúrguer", 15));
        restaurante.CadastrarProduto(new Produto(2, "Batata Frita", 8));
        restaurante.CadastrarProduto(new Produto(3, "Refrigerante", 6));

        // BOAS-VINDAS AO USUÁRIO

        Console.WriteLine("Bem-vindo ao Ponei Fritas");
        
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Digite seu telefone: ");
        string telefone = Console.ReadLine();
        
        // CRIAÇÃO DO USUÁRIO

        Usuario usuario = new Usuario(nome, telefone);

        int opcao;

        // MENU PRINCIPAL (LOOP)

        do
        {
            // Mostra as opções do menu para o usuário
            Console.WriteLine("\n1 - Novo pedido");
            Console.WriteLine("2 - Ver pedidos anteriores");
            Console.WriteLine("3 - Sair");

            // Lê o que o usuário digitou e converte para número
            opcao = int.Parse(Console.ReadLine());

            // ==============================
            // OPÇÃO 1 - FAZER NOVO PEDIDO
            // ==============================

            if (opcao == 1)
            {
                // Cria um novo pedido para o usuário
                // O ID do pedido é baseado na quantidade de pedidos já existentes
                Pedido pedido = new Pedido(restaurante.Pedidos.Count + 1, usuario);

                int escolha;
                // Variável para saber se o usuário quer adicionar mais produtos

                // ==============================
                // LOOP PARA ADICIONAR PRODUTOS
                // ==============================

                do
                {
                    // Mostra todos os produtos disponíveis no restaurante
                    restaurante.ListarProdutosDisponiveis();

                    Console.Write("Escolha o ID do produto: ");
                    // Pede para o usuário digitar o ID do produto

                    int idProduto = int.Parse(Console.ReadLine());
                    // Lê o ID digitado e converte para número

                    // Busca o produto correspondente ao ID
                    Produto produto = restaurante.BuscarProdutoPorId(idProduto);

                    // Se o produto existir, adiciona no pedido
                    if (produto != null)
                    {
                        pedido.AdicionarProduto(produto);
                    }

                    Console.Write("Adicionar outro produto? (1-Sim / 2-Finalizar): ");
                    // Pergunta se o usuário quer continuar escolhendo produtos

                    escolha = int.Parse(Console.ReadLine());
                    // Lê a escolha do usuário

                } while (escolha == 1);
                // Enquanto o usuário digitar 1, o loop continua

                // FINALIZAÇÃO DO PEDIDO

                usuario.FazerPedido(restaurante, pedido);
                // Associa o pedido ao usuário e ao restaurante

                pedido.FinalizarPedido();
                // Mostra o resumo do pedido (produtos + total)

                Console.WriteLine("Pedido estará pronto em breve!");
                // Mensagem final do pedido
            }

            // OPÇÃO 2 - VER PEDIDOS ANTERIORES

            else if (opcao == 2)
            {
                // Mostra todos os pedidos já feitos pelo usuário
                usuario.VerPedidosAnteriores();
            }

            // Se for opção 3, o loop acaba automaticamente

        } while (opcao != 3);
        // Enquanto a opção NÃO for 3, o menu continua aparecendo

        // ENCERRAMENTO DO SISTEMA

        Console.WriteLine("Obrigado pela preferência!");

}







