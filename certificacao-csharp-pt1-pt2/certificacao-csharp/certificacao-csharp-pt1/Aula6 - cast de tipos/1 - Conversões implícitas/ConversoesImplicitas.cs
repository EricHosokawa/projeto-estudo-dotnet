using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            ///conversao implicita para tipos de valor, so ocorre quando a capacidade do tipo da variavel que recebera o valor for maior ou igual a capacidade do tipo da variavel convertida
            int inteiro = 2_123_456_789;
            long longo = inteiro; ///capacidade do long > capacidade do int

            Console.WriteLine(longo);


            ///conversao implicita para tipos de referencia, so ocorre quando o tipo convertido for uma classe herdada 
            Gato gato = new Gato();
            Animal animal = gato; ///a classe derivada Gato herda da classe base Animal

            Console.WriteLine(animal.GetType());

            //para as interfacer tbm seguem a msm regra
            IAnimal ianimal1 = animal;
            IAnimal ianimal2 = gato;

            Console.WriteLine(ianimal1.GetType());
            Console.WriteLine(ianimal2.GetType());
        }
    }
}

