using System;

internal class Produto
{
    public Produto(int id, string nome, double valor)
    {
        (Id, Nome, Valor) = (id, nome, valor);
    }

    public string Nome { get; set; }
    public int Id {get; set;}
    public double Valor {get; set;}

}