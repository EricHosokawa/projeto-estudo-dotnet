using System;
using Topico1;

namespace TesteVisibilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;

            Console.WriteLine(conta.Saldo);
        }
    }
}
