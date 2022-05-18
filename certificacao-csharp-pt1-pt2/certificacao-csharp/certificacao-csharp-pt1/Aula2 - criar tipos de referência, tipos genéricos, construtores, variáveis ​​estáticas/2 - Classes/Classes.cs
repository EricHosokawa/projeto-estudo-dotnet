using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Classes : IAulaItem
    {
        ///necessario instanciar a class antes de atribuir os valores
        ///pode usar construtor com e sem parametros
        

        public void Executar()
        {
            var gps = new ClassePosicaoGPS() { Latitude = 13.78, Longitude = 29.51 };
            Console.WriteLine(gps.ToString());

            gps = new ClassePosicaoGPS(13.78, 29.51);
            Console.WriteLine(gps.ToString());
            Console.WriteLine($"está no hemisfério norte? {gps.HemisferioNorte()}");

            var gps2 = new GPSComLeitura(13.78, 29.51, DateTime.Now);
            Console.WriteLine(gps2.ToString());
        }

        interface IGPS
        {
            bool HemisferioNorte();
        }

        public class ClassePosicaoGPS : IGPS
        {
            public double Latitude;
            public double Longitude;

            public ClassePosicaoGPS()
            {

            }

            public ClassePosicaoGPS(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }

            public bool HemisferioNorte()
            {
                return Latitude > 0;
            }

            public override string ToString()
            {
                return $"Latitude: {Latitude}, Longitude: {Longitude}";
            }
        }


        ///classe derivada, herda tudo da classe base (mae/pai), desde propriedade a metodos
        ///use classe derivada com herança caso precise criar metodos ou construtores com novos parametros, sem a necessidade de alterar a classe base/mae/pai

        ///modificadores : internal, private, public, protected
        ///private - valor default quando o modificador nao é informado, acessivel apenas a classe em que esta contida
        ///internal - acessivel apenas ao projeto, ao mesmo codigo assembly
        ///public - acessivel por qualquer outra classe ou projeto, sem restricoes
        ///protected - acessivel apenas a classe q esta contida ou derivada dela

        public class GPSComLeitura : ClassePosicaoGPS
        {
            private readonly DateTime dataLeitura;

            ///uso da base para referenciar o construtor da classe base
            public GPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
            {
                ///this refere-se a propriedade da classe, nao ao parametro do metodo
                this.dataLeitura = dataLeitura;
            }

            public override string ToString()
            {
                ///uso da base para referenciar o metodo da clase
                return base.ToString() + $", Data Leitura: {dataLeitura}";
            }
        }
    }
}
