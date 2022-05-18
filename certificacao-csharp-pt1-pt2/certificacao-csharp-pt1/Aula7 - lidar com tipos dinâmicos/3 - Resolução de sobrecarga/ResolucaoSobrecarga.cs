using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ResolucaoSobrecarga : IAulaItem
    {
        //int Somar(int parcela1, int parcela2)
        //{
        //    return parcela1 + parcela2;
        //}

        //short Somar(short parcela1, short parcela2)
        //{
        //    return (short)(parcela1 + parcela2);
        //}

        //object Somar(object parcela1, object parcela2)
        //{
        //    return (double)parcela1 + (double)parcela2;
        //}

        ///podemos utilizar tipo dynamic, tanto como argumento, qnto para retorno...para resolver os problemas de sobrecarga
        ///evitando assim criar metodos semalhantes para tipos diferetes,
        ///como visto acima, comentamos e criamos apenas um metodo, com tipo dynamic
        dynamic Somar(dynamic parcela1, dynamic parcela2)
        {
            ///aqui ele realiza a conversao em tempo de execucao
            return parcela1 + parcela2;
        }

        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;

            short short1 = 123;
            short short2 = 456;

            double double1 = 123.45;
            double double2 = 456.78;

            Console.WriteLine(Somar(int1, int2));
            Console.WriteLine(Somar(short1, short2));
            Console.WriteLine(Somar(double1, double2));


            ///devemos tomar cuidado apenas qndo chamamos o metodo, para passar os parametros do tipo certo, em relacao a funcao do metodo
            ///descomente e note o erro em tempo de execucao
            //Console.WriteLine(Somar("a", "b")); //impossivel relizar a operacao de some em duas strings
        }
    }
}
