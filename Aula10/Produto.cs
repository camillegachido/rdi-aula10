using System;

internal class Produto
{
    Random rnd = new Random();
    public Produto(string nome, double valor)
    {
        (Nome, Valor) = (nome, valor);
        Id = rnd.Next();
    }

    public string Nome { get; set; }
    public int Id {get; set;}
    public double Valor {get; set;}

}