using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            ///float é um alias para o tipo System.Single
            ///ponto flutuante simples e de pouca precisao
            float idade = 15;

            idade = 15.5f;

            Console.WriteLine($"long.MinValue: { long.MinValue } ");
            Console.WriteLine($"long.MinValue: { long.MaxValue } ");

            float massaDaTerra = 5.9736e24f;
            Console.WriteLine($"massa da Terra: { massaDaTerra } ");

            float pi = 3.14159f;
            Console.WriteLine($"PI: { pi } ");
        
            ///double é um alias para o tipo System.Double
            ///capacidade numerica maior em relacao a outros pontos de flutuantes
            double numeroMaior = 6e100;
            Console.WriteLine($"Numero Maior: { numeroMaior }");

            int x = 3;
            short y = 5;
            var resultado = x * y;
            ///aqui o tipo do resultado sera referente ao tipo com maior capacidade numerica
            ///nesse caso o Sytem.Int32 (alias int)
            Console.WriteLine($" o resultado é : { resultado } e o tipo é : { resultado.GetType() }");

            float z = 4.5f;
            var resultado2 = (x * y) / z;
            ///aqui o tipo do resultado sera referente ao tipo com maior capacidade numerica
            ///nesse caso o System.Single (alias float)
            Console.WriteLine($" o resultado é : { resultado2 } e o tipo é : { resultado2.GetType() }");
        }
    }
}
