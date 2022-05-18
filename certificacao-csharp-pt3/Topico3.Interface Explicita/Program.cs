using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///IMPORTANTE:
            ///para acessar o metodo ou propriedade de cada interface implementada de forma explicita, 
            ///devemos realizar o cast da interface na propriedade que queremos atribuir ou no metodo que queremos chamar

            Funcionario funcionario = new Funcionario(1500); //aqui acessamos os metodos e propriedade apenas da interface IFuncionario

            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            ///fazemos entao o cast da interface na propriedade
            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            Console.WriteLine("Carga Horário Funcionário : " + ((IFuncionario)funcionario).CargaHorariaMensal);
            ((IPlantonista)funcionario).CargaHorariaMensal = 32;
            Console.WriteLine("Carga Horário Plantonista : " + ((IPlantonista)funcionario).CargaHorariaMensal);

            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };

            ///fazemos entao o cast da interface no metodo tbm
            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();

            Console.ReadLine();
        }
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

    ///interfaces implementadas de forma explicita, sao usadas quando termos interfaces com assinaturas de mesmo nome, mas de implementacoes diferentes
    ///e precisamos informar de forma explicita, na classe, a qual interface o metodo ou propriedade ela pertence
    ///regras gerais:
    ///devemos informar qual interface ela pertence, implementando o nome da interface com ., conforme abaixo
    ///todo metodo implementado de uma interface explicita não devem conter modificadores, pois ela é obrigatoriamente public


    class Funcionario : IFuncionario, IPlantonista
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public event EventHandler CrachaGerado;

        ///interface implementar de forma explicita
        void IFuncionario.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        ///interface implementar de forma explicita
        void IPlantonista.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        public decimal Salario { get; }

        ///interface implementar de forma explicita
        int IFuncionario.CargaHorariaMensal { get; set; }

        ///interface implementar de forma explicita
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
}
