using Aula10;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Bem-vindo ao Pônei Donald!");

		// Instanciar restaurante e produtos de exemplo
		var restaurante = new Restaurante();
		restaurante.CadastrarProduto(new Produto { Id = 1, Nome = "Hambúrguer", Valor = 15.99m, QtdEstoque = 10 });
		restaurante.CadastrarProduto(new Produto { Id = 2, Nome = "Batata Frita", Valor = 7.99m, QtdEstoque = 20 });
		restaurante.CadastrarProduto(new Produto { Id = 3, Nome = "Refrigerante", Valor = 5.99m, QtdEstoque = 15 });

		// Cadastro do usuário
		Console.Write("Digite seu nome: ");
		var nome = Console.ReadLine();
		Console.Write("Digite seu telefone: ");
		var telefone = Console.ReadLine();
		var usuario = new Usuario { Nome = nome, Telefone = telefone };

		// Menu principal
		int opcao;
		do
		{
			Console.WriteLine("\nMenu Principal:");
			Console.WriteLine("1 - Fazer um novo pedido");
			Console.WriteLine("2 - Ver pedidos anteriores");
			Console.WriteLine("3 - Sair");
			Console.Write("Escolha uma opção: ");
			int.TryParse(Console.ReadLine(), out opcao);

			switch (opcao)
			{
				case 1:
					FazerPedido(usuario, restaurante);
					break;
				case 2:
					usuario.VerPedidosAnteriores();
					break;
				case 3:
					Console.WriteLine("Saindo...");
					break;
				default:
					Console.WriteLine("Opção inválida!");
					break;
			}
		} while (opcao != 3);
	}

	static void FazerPedido(Usuario usuario, Restaurante restaurante)
	{
		var pedido = new Pedido();
		bool continuar = true;
		while (continuar)
		{
			restaurante.ListarProdutosDisponiveis();
			Console.Write("Digite o ID do produto para adicionar ao pedido: ");
			int.TryParse(Console.ReadLine(), out int idProduto);
			var produto = restaurante.BuscarProdutoPorId(idProduto);
			if (produto == null || produto.QtdEstoque <= 0)
			{
				Console.WriteLine("Produto inválido ou sem estoque.");
				continue;
			}
			Console.Write("Quantidade: ");
			int.TryParse(Console.ReadLine(), out int quantidade);
			if (quantidade <= 0 || quantidade > produto.QtdEstoque)
			{
				Console.WriteLine("Quantidade inválida.");
				continue;
			}
			pedido.AdicionarProduto(produto, quantidade);
			produto.QtdEstoque -= quantidade;

			Console.Write("Deseja adicionar outro produto? (s/n): ");
			var resp = Console.ReadLine();
			if (resp?.ToLower() != "s")
				continuar = false;
		}
		usuario.FazerPedido(restaurante, pedido);
		pedido.FinalizarPedido();
	}
}
