using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        ///tipo de valor simples, possivel encapsular propriedades e funcoes
        ///como não é tipo primitivo tbm usa a stack para alocacao de memoria
        ///sem necessidade de instanciar
        ///construtor apenas com parametros
        ///nao suporta heranca
        ///usar somente quando tiver certeza que a instancia e a duracao de execucao serao pequenas
        ///usar de preferencia embutido em algum metodo ou classe
        ///se a comecar a ficar grande demais, usar classe, evitando o stack overflow


        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            PosicaoGPS gps1;
            gps1.Latitude = 13.78;
            gps1.Longitude = 29.51;
            Console.WriteLine(gps1.ToString());

            var gps2 = new PosicaoGPS(13.78, 29.51);
            Console.WriteLine(gps2.ToString());
            Console.WriteLine($"está no hemisfério norte? {gps2.HemisferioNorte()}");
        }

        interface IGPS
        {
            bool HemisferioNorte();
        }

        struct PosicaoGPS : IGPS
        {
            public double Latitude;
            public double Longitude;

            public PosicaoGPS(double latitude, double longitude)
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
    }
}
