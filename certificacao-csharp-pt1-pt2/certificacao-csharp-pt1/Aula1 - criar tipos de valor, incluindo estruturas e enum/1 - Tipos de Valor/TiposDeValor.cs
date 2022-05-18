using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        ///os tipo de valor sao alocados na memoria stack, ou seja, tem memoria limitada de uso
        ///uso incorreto e desenfreado dos tipo de valor, causam o stack overflow
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine($"idade inicial : {idade}");

            ///tipo de valor não aceitam referencias, mesmo que seja uma copia da original
            ///as copias nao sao alteradas, mesmo quando a variavel original altera o valor, pois elas são independentes
            ///alocadas e apontadas para areas de diferentes da memoria
            int copiaIdade = idade;           
            idade = 50;
            Console.WriteLine($"idade : { idade }");
            Console.WriteLine($"idade : { copiaIdade }");
        }
    }
}
