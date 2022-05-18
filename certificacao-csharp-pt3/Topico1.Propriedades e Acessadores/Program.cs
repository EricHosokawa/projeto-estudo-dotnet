using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AulaPropriedadeGetSet();

            AulaPropriedadeGetSet2();
        }

        static void AulaPropriedadeGetSet()
        {
            Funcionario funcionario = new Funcionario("João da Silva");

            funcionario.Idade = 32;
            funcionario.Salario = 1000;

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.Idade);
            Console.WriteLine(funcionario.Salario);

            Console.ReadLine();
        }

        static void AulaPropriedadeGetSet2()
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;

            Console.WriteLine(conta.Saldo);
        }
    }

    class Funcionario
    {
        ///trabalhando com propriedades e encasulamento
       
        

        ///atalho para criar propriedade = prop + tab + tab

        ///podemos criar propriedade apenas com o acessador get, ou seja, somente leitura do campo
        ///sendo assim para atribuir algum valor a ele, podemos implementar no construtor
        public string Nome { get; }

        ///criamos entao um construtor que ira atribuir o valor a propriedade, que externamente é somente leitura
        public Funcionario(string nome)
        {
            this.Nome = nome;
        }




        ///podemos criar propriedade com get e set puros, ou seja, sem implementacao, 
        ///e o .net cria de forma implicita e automatica os campos para o acessadores
        ///nesse exemplo o compilador .net cria o campo 'nome' de forma implicita
        public int Idade { get; set; }




        ///podemos criar a propriedade acessivel com o campo inacessivel, para trabalharmos com regras dentro dos acessadores
        ///atalho para criar propriedade com campo = propfull + tab + tab

        ///campo salario deve ser inacessivel
        ///propriedade sem modificador é uma propriedade privada como padrão
        private decimal salario;

        ///criamos uma propriedade Salario acessivel, para encapsular o campo salario
        public decimal Salario
        {
            get
            {
                return salario;
            }

            set
            {
                ///tratar no set as regras da propriedade
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Salário não pode ser negativo.");

                salario = value;
            }
        }
    }

    public class Conta
    {
        public Conta()
        {
            this.Saldo = 1000;
            Console.WriteLine(this.Saldo);
        }

        void Sacar(decimal saque)
        {
            Saldo = Saldo - saque;
        }


        ///trabalhando com a visibilidade dos acessadores
        ///podemos baixar a vibilidade os acessadores, porém não conseguimos aumentar em relação a propriedade
        ///ou seja, se a prop é public, os acessadores são implicitamento publicas, caso não informe o modificador
        public decimal Saldo { get; set;  }

        ///podemos entao diminunir a visibilidade dos acessadores, conforme nos exemplos abaixo

        ///descomente e veja que o get da prop agora está visivel apenas a propria classe
        //public decimal Saldo { private get; set; }

        ///descomente e veja que o set da pro agora está visivel apenas ao projeto, e invisivel aos outros projetos que usam como referencia
        //public decimal Saldo { get; internal set; }


        ///descomente e veja que o set da prop agora está visivel apenas a propria classe e as classes devivadas
        //public decimal Saldo { get; protected set; }

        ///descomente e veja que o set agora está invisivel para todos, ate mesmo para a propria classe, 
        ///sendo possivel atribui o valor apenas pelo construtor
        //public decimal Saldo { get; }

        
        ///descomente e veja que a prop agora está visivel apenas a propria classe, e seus derivados 
        ///e os acessadores herdam de forma implicita o modificador da propriedade,
        ///e tbm o modificador dos acessadores não podem ser mais visivel que o da prop, ou seja, não podem ser mais visivel q internal
        //intenal decimal Saldo { get; set; }
    }

    class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            this.Saldo = 1000;
            Console.WriteLine(this.Saldo);
        }
    }
}
