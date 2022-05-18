using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    ///delegate é um representante do metodo, representa metodos especificos, desde que tenham mesma entrada e saida
    ///podem ser utilizados como variaveis que representam metodos
    ///mto usados em eventos/orientacao eventos (callback)
    delegate double MetodoMultiplicacao(double input);


    class Calculadora
    {
        ///metodo que sera representado pelo delegate na execucao
        static double Duplicar(double input)
        {
            return input * 2;
        }

        ///metodo que sera representado pelo delegate na execucao
        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            //Executa diretamente o método
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //Executa diretamente o método
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");


            ///uso do delegate para possibilitar que o metodos sejam atribuido em uma variavel
            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine($"duplicar 7.5 : {metodoMultiplicacao(7.5)}");

            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"triplicar 7.5 : metodoMultiplicacao(7.5)");


            ///outro uso para o delegate é com metodos anonimos
            MetodoMultiplicacao metodoQuadrado = delegate (double input) 
            {
                return input * input;
            };

            Console.WriteLine($"quadrado de 5 : {metodoQuadrado(5)}");


            ///outro uso para o delegate é com metodos usando lambda
            MetodoMultiplicacao metodoCubo = input => Math.Pow(input, 3);
            Console.WriteLine($"cubo de 5 : {metodoCubo(5)}");
        }
    }
}
