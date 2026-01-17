using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Valor { get; set; }



    public Produto(int id, string nome, double valor)
    {
        Id = id;
        Nome = nome;
        Valor = valor;
    }
}
