using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            decimal numero = 57.2m;
            object caixa = numero; //boxing

            ///conceito de unboxing, recuperar o valor atribuido no boxing da variavel object auxiliar
            ///porem recuperar, sera necessario um conversao explicita do objeto para a variavel que recebera o valor do unboxing
            int unboxed = (int)(decimal)caixa; //unboxing

            Console.WriteLine(string.Concat("Unboxing", unboxed, true));
        }
    }
}
