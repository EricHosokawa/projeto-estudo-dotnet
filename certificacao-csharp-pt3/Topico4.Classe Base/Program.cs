using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            ((IPlantonista)funcionario).CargaHorariaMensal = 32;
            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };
            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();

            Cliente cliente = new Cliente()
            {
                CPF = "789456123-99",
                DataNascimento = new DateTime(1980, 1, 1),
                Nome = "Maria de Souza",
                DataUltimaCompra = new DateTime(2018, 1, 1),
                ValorUltimaCompra = 200
            };

            Console.WriteLine(cliente);

            Console.ReadLine();

            ///classe abstrata não pode instanciar
            ///descomente, e veja que não e impossivel instanciar a classe
            //Pessoa pessoa = new Pessoa()
            //{
            //    CPF = "789456123-99",
            //    DataNascimento = new DateTime(1980, 1, 1),
            //    Nome = "Maria de Souza"
            //};
        }
    }

    ///classe base, basicamente é uma classe com informações comuns entre outras classes, e servirá como pai/mae
    ///regras gerais:
    ///é uma classe normal, não é uma interface
    ///uma classe derivada pode herdar apenas uma classe base
    ///nas classes derivadas, a referencia deve vir antes das interfaces
    ///não precisa recriar os campos da classe base na classe derivada

    ///classe abstrata, impede que criem instancias a partir dela, apenas das herdeiras 
    ///servira apenas como classe base

    abstract class Pessoa
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }

    interface IFuncionario
    {
        string CPF { get; set; }
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }

        event EventHandler CrachaGerado;

        void GerarCracha();

        decimal Salario { get; }
        int CargaHorariaMensal { get; set; }

        void EfeturarPagamento();
    }

    interface IPlantonista
    {
        int CargaHorariaMensal { get; set; }
        void GerarCracha();
    }

    class Funcionario : Pessoa, IFuncionario, IPlantonista
    {
        public event EventHandler CrachaGerado;

        void IFuncionario.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        void IPlantonista.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        public decimal Salario { get; }

        int IFuncionario.CargaHorariaMensal { get; set; }

        int IPlantonista.CargaHorariaMensal { get; set; }

        public Funcionario(decimal salario)
        {
            Salario = salario;
        }

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }

    sealed class Cliente: Pessoa
    {
        public DateTime? DataUltimaCompra { get; set; }
        public decimal? ValorUltimaCompra { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data última compra: {DataUltimaCompra}";
        }
    }

    

    ///Multoplas heranças
    ///é possivel criar varias heranças até mesmo com classes já derivadas
    
    ///sealed, diferenta da abstract, esse modificador impede que outras classes herdem dela,
    ///assim evitam as multiplas heranças, e a perda de performance
    
    ///descomente, e veja que é impossivel herdar da classe sealed
    //class ClienteEspecial : Cliente
    //{

    //}

    //class ClientePromocional : Cliente
    //{

    //}
}
