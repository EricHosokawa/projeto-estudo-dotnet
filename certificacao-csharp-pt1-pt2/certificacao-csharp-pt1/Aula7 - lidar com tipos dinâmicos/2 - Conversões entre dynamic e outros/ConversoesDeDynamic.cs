using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            ///declarando alguns dynamic de varios tipos, não precisa converter 
            dynamic d1 = 7;
            dynamic d2 = "string qualquer";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 1, 2, 3, 123, 456 };

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);




            ///declarando novas variaveis tipadas, e recebendo as dynamics, tbm não precisa converter
            ///conversao implicita é realizada desde que seja do mesmo tipo, string para string, int para int, date para date
            int i = d1;
            string str = d2;
            DateTime dt = d3;
            List<int> lst = d4;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);


            ///conversoes devem ser realizadas qndo necessario, para nao ocorrer erro em tempo de execucao
            str = d1.ToString();
            Console.WriteLine(str);
        }
    }
}
