using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///usamos interface para declarar variaveis que permitam alterar o tipo do objeto desde que facam parte dessa interface
            IEletrodomestico eletro1 = new Televisao();
            IEletrodomestico eletro2 = new Abajur();
            IEletrodomestico eletro3 = new Lanterna();
            IEletrodomestico eletro4 = new Radio();
            eletro1 = new Abajur();
            eletro2 = new Televisao();
            eletro3 = new Radio();
            eletro4 = new Lanterna();


            IIluminacao iluminacao = new Abajur();
            iluminacao = new Lanterna();


            IRadioReceptor receptor = new Radio();
            receptor = new Televisao();
        }
    }

    ///interfaces permitem criar um contrato com assinaturas de propriedade e metodos, porém não dita qual sera implementacao
    ///agrupa em um interface os metodos e propriedades com nomes iguais, entre as classes
    ///ao trabalharmos com interfaces, as propriedades e metodos implicitamente são publicas,
    ///assim não necessitamos informar o modificados
    
    ///interface se assemelham a uma classe abastrata
    ///interface contem membros abstratos
    ///porem um classe pode herdar varias interfaces, mas apenas uma classe abstrata

    
    interface IEletrodomestico
    {   
        event EventHandler Ligou;
        event EventHandler Desligou;

        void Desligar();
        void Ligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    interface IRadioReceptor
    {
        double Frequencia { get; set; }
    }

    class Televisao : IEletrodomestico, IRadioReceptor
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double Frequencia { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
            if (Ligou != null)
            {
                Ligou(this, new EventArgs());
            }
        }
    }

    ///podemos informar mais de uma interface para um classe
    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : IEletrodomestico, IRadioReceptor
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double Frequencia { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

}
