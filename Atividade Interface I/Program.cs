using System;
using Atividade_Interface_I;

class Program
{
    public static void Main(string[] args)
    {
        Computador computador1 = new Computador();
        Fornecedor fornecedor1 = computador1.RecuperarFornecedor();
        Console.WriteLine("Fornecedor: " + fornecedor1.marca);
        Cliente cliente = new Cliente("Iesus");

        computador1.RegistrarVenda(cliente);
        Console.ReadKey();
    }
}