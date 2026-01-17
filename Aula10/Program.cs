using System;
using System.Collections.Generic;
using System.Linq;
using FastFoodSystem;

class Program{
    static void Main(string[] args)
    {
        Restaurante restaurante = new Restaurante();

        restaurante.CadastrarProduto(new Produto(1, "Hambúrguer", 15.00m, 50));
        restaurante.CadastrarProduto(new Produto(2, "Batata Frita", 7.50m, 100));
        restaurante.CadastrarProduto(new Produto(3, "Refrigerante", 5.00m, 200));

        Console.WriteLine("Bem-vindo ao Pônei Donald!");

        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu telefone:");
        string telefone = Console.ReadLine();
        Usuario usuario = new Usuario(nome, telefone);

        Console.WriteLine("1 - Fazer um novo pedido");
        Console.WriteLine("2 - Ver pedidos anteriores");
        Console.WriteLine("3 - Sair");
        Console.Write("Opção: ");

        int opcao = int.Parse(Console.ReadLine())
        if (opcao == 1)
        {//fazer pedido 
        return
        }


    
    }
}