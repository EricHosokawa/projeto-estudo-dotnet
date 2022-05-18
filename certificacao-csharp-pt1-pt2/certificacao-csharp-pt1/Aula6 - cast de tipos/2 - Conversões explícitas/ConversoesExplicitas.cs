using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            ///conversao explicita para tipos de valor, necessario quando os tipos sao diferentes, e precisamos forcar a conversao
            double divida = 1_234_567_890.123;
            long copiaDivida = (long)divida; ///neste caso, prde-se as casas decimais, pois long nao tem cada decimal

            Console.WriteLine(copiaDivida);


            ///conversao implicita para tipos de referencia, necessario quando os tipo sao diferentes, tbm sera necessario forcar a conversao
            Animal animal = new Gato();
            Gato gato = (Gato)animal; ///necessario realizar o cast, desde que seja uma classe derivada

            Console.WriteLine(gato.GetType());
        }
    }
}
