using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class OperadoresDeConversao : IAulaItem
    {
        public struct AnguloEmRadianos
        {
            public double Radianos { get; }

            public AnguloEmRadianos(double radianos)
            {
                this.Radianos = radianos;
            }

            ///operadores de conversao - metodos para realizar conversoes 
            ///regras gerais:
            ///precisa ser um metodo do tipo public e static
            ///informar que o metodo é implicito ou explicito - nesse caso um implicito
            ///informar que o metodo é um operador - nesse caso um operador de conversao
            ///o metodo nao tem nome, pois é implicito que é um operador


            ///conversao implicita de um AnguloEmGraus
            public static implicit operator AnguloEmRadianos(AnguloEmGraus graus)
            {
                return new AnguloEmRadianos(graus.Graus * System.Math.PI / 180);
            }

            ///conversao explicita de um double
            public static implicit operator AnguloEmRadianos(double radianos)
            {
                return new AnguloEmRadianos(radianos);
            }

            ///conversao explicita de um AnguloEmRadianos para double
            public static implicit operator double(AnguloEmRadianos radianos)
            {
                return radianos.Radianos;
            }

            public override string ToString()
            {
                return String.Format("{0} radianos", this.Radianos);
            }
        }

        public struct AnguloEmGraus
        {
            public double Graus { get; }

            public AnguloEmGraus(double graus)
            {
                this.Graus = graus;
            }

            ///aqui mostramos um caso explicito, ou seja, sera necessario realizar o cast

            ///conversao explicita de um AnguloEmRadianos
            public static explicit operator AnguloEmGraus(AnguloEmRadianos radianos)
            {
                return new AnguloEmGraus(radianos.Radianos * 180 / System.Math.PI);
            }

            ///conversao explicita de um double
            public static explicit operator AnguloEmGraus(double graus)
            {
                return new AnguloEmGraus(graus);
            }

            ///conversao explicita de um AnguloEmGraus para double
            public static explicit operator double(AnguloEmGraus graus)
            {
                return graus.Graus;
            }

            public override string ToString()
            {
                return String.Format("{0} graus", this.Graus);
            }
        }

        public void Executar()
        {
            ///conversao explicita de um double para AnguloEmGraus
            AnguloEmGraus anguloEmGraus = (AnguloEmGraus)45; //necessario faer o cast
            Console.WriteLine(anguloEmGraus.ToString());

            ///conversao implicita de um double para AnguloEmRadianos
            AnguloEmRadianos anguloEmRadianos = 15;
            Console.WriteLine(anguloEmRadianos.ToString());

            ///conversao explicita de um AnguloEmGraus para double
            double graus = (double)anguloEmGraus;
            Console.WriteLine(graus);

            ///conversao explicita de um AnguloEmRadianos para double
            double radianos = anguloEmRadianos;
            Console.WriteLine(radianos);

            ///conversao implicita de um AnguloEmGraus
            anguloEmRadianos = anguloEmGraus;

            ///conversao explicita de um AnguloEmRadianos
            anguloEmGraus = (AnguloEmGraus)anguloEmRadianos;

            System.Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");
            System.Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");
        }
    }
}
