using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFoodSimples
{
    // =======================
    // Classe Usuario
    // =======================
    public class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; } // identificador
        public List<Pedido> Pedidos { get; set; }

        public Usuario(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Pedidos = new List<Pedido>();
        }

        public void FazerPedido(Restaurante restaurante, Pedido pedido)
        {
            // associa o pedido ao usuário
            pedido.Usuario = this;

            // adiciona ao histórico do usuário
            Pedidos.Add(pedido);

            // adiciona ao histórico do restaurante
            restaurante.Pedidos.Add(pedido);
        }

        public void VerPedidosAnteriores()
        {
            Console.WriteLine();
            Console.WriteLine("=== Seus pedidos anteriores ===");

            if (Pedidos.Count == 0)
            {
                Console.WriteLine("Você ainda não fez nenhum pedido.");
                return;
            }

            foreach (var p in Pedidos)
            {
                Console.WriteLine($"Pedido #{p.Id} - {p.Hora:dd/MM/yyyy HH:mm} - Total: R$ {p.CalcularTotal():0.00}");
            }
        }
    }

    // =======================
    // Classe Produto
    // =======================
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        // Para atender "estoque > 0" do enunciado
        public int QtdEstoque { get; set; }

        public Produto(int id, string nome, decimal valor, int qtdEstoque)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            QtdEstoque = qtdEstoque;
        }
    }

    // =======================
    // Classe Pedido
    // =======================
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Hora { get; set; }
        public Usuario Usuario { get; set; } // será preenchido no FazerPedido
        public List<Produto> Produtos { get; set; }

        public Pedido(int id)
        {
            Id = id;
            Hora = DateTime.Now;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            // controle simples de estoque
            if (produto.QtdEstoque <= 0)
            {
                Console.WriteLine("Sem estoque desse produto.");
                return;
            }

            Produtos.Add(produto);
            produto.QtdEstoque--; // baixa 1 unidade
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var prod in Produtos)
            {
                total += prod.Valor;
            }
            return total;
        }

        public void FinalizarPedido()
        {
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Não é possível finalizar um pedido sem produtos.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("=== RESUMO DO PEDIDO ===");
            Console.WriteLine($"Pedido #{Id} - {Hora:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"Cliente: {Usuario.Nome} - Tel: {Usuario.Telefone}");
            Console.WriteLine("Itens:");

            foreach (var prod in Produtos)
            {
                Console.WriteLine($"- {prod.Nome} (R$ {prod.Valor:0.00})");
            }

            Console.WriteLine($"TOTAL: R$ {CalcularTotal():0.00}");
            Console.WriteLine("Seu pedido estará pronto em breve.");
        }
    }

    // =======================
    // Classe Restaurante
    // =======================
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
        }

        public Produto BuscarProdutoPorId(int id)
        {
            foreach (var p in Produtos)
            {
                if (p.Id == id) return p;
            }
            return null;
        }

        public void ListarProdutosDisponiveis()
        {
            Console.WriteLine();
            Console.WriteLine("=== CARDÁPIO (estoque > 0) ===");

            bool temAlgum = false;

            foreach (var p in Produtos)
            {
                if (p.QtdEstoque > 0)
                {
                    Console.WriteLine($"{p.Id} - {p.Nome} | R$ {p.Valor:0.00} | Estoque: {p.QtdEstoque}");
                    temAlgum = true;
                }
            }

            if (!temAlgum)
            {
                Console.WriteLine("Sem itens disponíveis no momento.");
            }
        }
    }

    // =======================
    // Programa (Interface)
    // =======================
    class Program
    {
        static int proximoIdPedido = 1;

        static void Main()
        {
            var restaurante = new Restaurante();

            // Produtos iniciais
            restaurante.CadastrarProduto(new Produto(1, "Hamburguer da Grupo 8", 18.90m, 10));
            restaurante.CadastrarProduto(new Produto(2, "Batata Frita", 9.50m, 10));
            restaurante.CadastrarProduto(new Produto(3, "Coca Zero", 7.00m, 10));
            restaurante.CadastrarProduto(new Produto(3, "Fanta Uva", 7.00m, 10));
            restaurante.CadastrarProduto(new Produto(3, "Guarana", 7.00m, 10));

            Console.WriteLine("Bem vindo ao Pônei Donald!");
            Console.WriteLine();

            // Cadastro do usuário
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            string telefone = Console.ReadLine();

            var usuario = new Usuario(nome, telefone);

            // Menu principal
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Fazer um novo pedido");
                Console.WriteLine("2 - Ver pedidos anteriores");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                int opcao = LerInt();

                if (opcao == 3)
                {
                    Console.WriteLine("Até mais!");
                    break;
                }
                else if (opcao == 2)
                {
                    usuario.VerPedidosAnteriores();
                }
                else if (opcao == 1)
                {
                    var pedido = new Pedido(proximoIdPedido);
                    proximoIdPedido++;

                    while (true)
                    {
                        restaurante.ListarProdutosDisponiveis();

                        Console.Write("Digite o ID do produto: ");
                        int idProd = LerInt();

                        var produto = restaurante.BuscarProdutoPorId(idProd);

                        if (produto == null)
                        {
                            Console.WriteLine("Produto não encontrado.");
                            continue;
                        }

                        pedido.AdicionarProduto(produto);

                        Console.WriteLine();
                        Console.WriteLine("1 - Adicionar outro produto");
                        Console.WriteLine("2 - Finalizar pedido");
                        Console.Write("Escolha: ");

                        int acao = LerInt();

                        if (acao == 2)
                        {
                            // Registra o pedido no usuário e restaurante
                            usuario.FazerPedido(restaurante, pedido);

                            // Finaliza (mostra resumo)
                            pedido.FinalizarPedido();
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
        }

        // Lê inteiro com TryParse (iniciante, sem travar)
        static int LerInt()
        {
            while (true)
            {
                string texto = Console.ReadLine();
                if (int.TryParse(texto, out int valor))
                    return valor;

                Console.Write("Digite um número válido: ");
            }
        }
    }
}