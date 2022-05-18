using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            ///string é um alias do tipo System.String
            ///apesar de ser um tipo de referencia ele se comporta como um tipo de valor
            ///ou seja, se realizar a copia de uma variavel para outra, elas se mantem independentes

            string a = "bom dia";
            string b = "b";

            ///por mais que sejam atribuidos valores de forma diferente, os string sao sempre iguais em sua estrutura de valor
            b = b + "om dia";
            Console.WriteLine($"a == b : {a == b}");

            ///para confirmar esta teoria, basta converte-los para object que deixam de ser iguais
            ///pois aq cada variavel esta apontada para areas diferentes da memoria, por isso são independentes
            Console.WriteLine($"cast para objects a == b : {(object)a == (object)b}");

            //string sao cadeias de caracteres
            string bomDia = "bom dia";
            Console.WriteLine($"bomDia[4] : {bomDia[4]}");

            var caractere = bomDia[4];
            Console.WriteLine($"caractere é do tipo : {caractere.GetType()}");
        }
    }
}
