using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            ///metodos auxiliares de conversao

            string textoDigitado = "123";
            int numeroConvertido;

            ///alguns tipo não podem ser convertidos por um conversao implicita ou explicita
            ///descomente e notara q é impossivel realizar a conversao
            //numeroConvertido = textoDigitado; //impossivel fazer a conversao implicita
            //numeroConvertido = (int)textoDigitado; //impossivel fazer a conversar explicita
            //numeroConvertido = textoDigitado as int; //impossivel fazer a conversao utilizando as


            ///para esse tipo de conversao sera necessario o uso de parse, um conversao de equivalencia entre tipos
            
            ///Parse, conversao simples sem validacao, nesse caso string em int
            numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine(numeroConvertido);


            textoDigitado = "abc";
            ///TryParse, realizar a tentativa de conversao se nao consegue retorna um false e parametro de retorno default do tipo 
            ///caso contrato retorna true e parametro de retorno convertido
            if(int.TryParse(textoDigitado, out numeroConvertido))
                Console.WriteLine(numeroConvertido);
            else
                Console.WriteLine("Texto não é um número.");


            textoDigitado = "R$ 123,45";
            ///atenção para conversao de decimal (valor monetario)
            ///devemos priorizar o uso do TryParse, informando o estilo e a cultura, para nao ocorrer erro na conversao
            ///importante saber o separador decimal que esta utilizando, se ponto ou virgula
            decimal.TryParse(
                    textoDigitado,
                    NumberStyles.Currency, //valor monetario
                    CultureInfo.CurrentCulture, //configura na maquina, nesse caso pt-br
                    out decimal valorConvertido);
                Console.WriteLine(valorConvertido);

        }
    }
}
