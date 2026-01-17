using System; 


    
     public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public decimal Valor {get; set;}
        public int Estoque {get; set; }

    }

        public class Pedido
{
        public int Id { get; set; }
        public DateTime Hora { get; set; }
        public String Usuario { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();


        public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.Valor;
        }
        return total;
    }

    public void FinalizarPedido()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("O pedido não pode ser finalizado sem produtos!");
            return;
        }

        Console.WriteLine("Resumo do Pedido:");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"- {produto.Nome} (R${produto.Valor})");
        }
        Console.WriteLine($"Total: R${CalcularTotal()}");
        Console.WriteLine("Seu pedido estará pronto em breve!");
    }
}



    public class Restaurante
{
    public List<Produto> Produtos {get; set;} = new List<Produto>();
    public List<Pedido> Pedidos {get; set;} = new List<Pedido>();

    public void ListarProduto()
    {
        foreach (var p in Produtos)
        {
            Console.WriteLine(p);
        }
    }
}

    public class Usuario
    {
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public List<Pedido> Pedidos {get; set;} = new List<Pedido>();

        public void FazerPedido(Restaurante restaurante, Pedido pedido)
    {
        // pedido.Usuario = this;
        // this

        List<string> Produto= new List<string>();

        Produto.Add("Hamburguer");

        Produto.Add("Batata");

        Produto.Add("Refrigerante");



        foreach (string produto in Produto)

        {

        Console.WriteLine(produto);

        }

                
    }

    }

    


class Program
{
    public static void  Main()
    {
        
        Console.WriteLine("Bem-vindo ao Pônei Donald!");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Usuario usuario = new Usuario {Nome = nome, Telefone = telefone};
        

        Produto Refrigerante = new Produto { Id = 1, Nome = "Refrigerante", Valor = 4 };
        Produto Hamburguer = new Produto { Id = 2, Nome = "Hamburguer", Valor = 10 };

        Pedido pedido = new Pedido {Id = 1, Hora = DateTime.Now, Usuario = nome };

        
    }

    
}
    




