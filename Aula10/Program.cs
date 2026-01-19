using System;
        
Restaurante restaurante = new Restaurante();
restaurante.CadastrarProduto(1, "Hambúrguer", 20);
restaurante.CadastrarProduto(2, "Batata frita", 10);
restaurante.CadastrarProduto(3, "Refrigerante", 5);
Usuario usuario = new Usuario("Mariazinha", "999999999");
int opcao;

do{
    
    Console.WriteLine("--- Bem vindo ao Pônei Donald! ---");
    Console.WriteLine("Insira 1 se deseja fazer um novo pedido");
    Console.WriteLine("Insira 2 se deseja ver seus pedidos anteriores");
    Console.WriteLine("Insira 3 se deseja sair:");

    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            restaurante.ListarProdutosDisponiveis();
            criaPedido();
            break;
        case 2:
            usuario.VerPedidosAnteriores();
            break;
        case 3 :
            Console.WriteLine("Saindo...");
            break;
        default:
            break;
    }

    Console.WriteLine("\n");
    
} while(opcao != 3);

    

void criaPedido()
{
    Pedido pedido = new Pedido(usuario);
    int idProduto;
    
    do
    {
        Console.WriteLine("Digite a Id do produto que deseja adicionar ao pedido ou digite 0 finalizar o pedido");
        idProduto = Convert.ToInt32(Console.ReadLine());
        if(idProduto != 0)
            pedido.AdicionarProduto(restaurante.BuscarProdutoPorId(idProduto));    
    } while (idProduto != 0);

    usuario.FazerPedido(restaurante, pedido); 
    pedido.FinalizarPedido();
}