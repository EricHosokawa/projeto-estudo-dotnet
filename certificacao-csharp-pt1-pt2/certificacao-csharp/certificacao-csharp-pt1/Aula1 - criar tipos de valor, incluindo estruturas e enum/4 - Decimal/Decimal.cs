using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valor1 = 10;
            double valor2 = 20;
            double total = 30;

            Console.WriteLine($"a soma é: { total } e { (valor1 + valor2) == total}");

            valor1 = 10.10;
            valor2 = 20.20;
            total = 30.30;
            Console.WriteLine($"a soma é: { total } e { (valor1 + valor2) == total }");
            Console.WriteLine($"a soma é: { valor1 + valor2 }");

            total = 30.299999999999997;
            Console.WriteLine($"internamente 10.1 + 20.2 = 30.299999999999997... é { valor1 + valor2 == total }");

            ///decimal é um alias para o tipo System.Decimal
            ///tipos decimais sao mais precisos que outros tipos de ponto flutuante
            ///se necessario realizar calculos financeiros deve usar o decimal
            ///use o sufixo m para informa que o numero e um decimal
            decimal valor3 = 10.1m;
            decimal valor4 = 20.2m;
            decimal total2 = 30.3m;
            Console.WriteLine($"a soma é { total } e { valor3 + valor4 == total2 } ");
        }
    }
}
