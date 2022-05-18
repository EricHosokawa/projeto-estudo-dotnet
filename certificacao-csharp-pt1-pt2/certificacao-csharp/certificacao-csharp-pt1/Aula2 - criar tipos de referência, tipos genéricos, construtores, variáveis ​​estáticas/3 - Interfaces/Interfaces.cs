using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            ///classes que herdam de mesma interface podem ser instanciadas com a interface como variavel
            ///possibilitando reutilizar a mesma variavel para outras classes de mesma heranca
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();

            eletro1 = new Radio();
            eletro1.Ligar();

            IIluminacao eletro2 = new Abajur();
            eletro2.PotenciaDaLampada = 15;

            eletro2 = new Lanterna();
            eletro2.PotenciaDaLampada = 9;
        }
    }

    ///uso de interfaces para classes que compartilham de metodos e propriedades com o mesmo nome

    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : IEletrodomestico
    {
        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }

    class Radio : IEletrodomestico
    {
        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}
