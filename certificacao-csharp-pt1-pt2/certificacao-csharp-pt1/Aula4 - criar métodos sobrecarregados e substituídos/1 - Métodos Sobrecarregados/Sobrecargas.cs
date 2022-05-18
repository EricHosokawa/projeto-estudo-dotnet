using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            ///na chamada do metodo, basta chamar passando os parametros corretos para cada metodo especifico

            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;
            Console.WriteLine($"Volume do cubo : {Volume(lado)}");


            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;
            Console.WriteLine($"Volume do cilindro : {Volume(altura, raio)}");


            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine($"Volume do prisma : {Volume(largura, profundidade, altura)}");
        }

        ///aq a sobrecarga do metodo pode ser usada quando existirem metodos semelhantes porem com as assinaturas distintas
        ///ou seja, nesse exemplo os metodos calculam o volume, mas o que diferencia e o tipo de objeto calculado (cubo, cilindro ou prisma)
        
        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}
