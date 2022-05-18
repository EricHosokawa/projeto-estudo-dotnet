using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            decimal numero = 57.2m;

            ///conceito de boxing, atribuindo o valor da variavel original, em uma variavel "auxiliar" do tipo object
            ///basicamente uma referencia de uma variavel, uma copia
            object caixa = numero; //boxing

            Console.WriteLine(string.Concat("Boxing", numero, true));


            ///o objeto referencia guarda o valor atribuido a ele anteriormente, mantendo até mesmo o tipo
            Console.WriteLine(caixa);

        }
    }
}
