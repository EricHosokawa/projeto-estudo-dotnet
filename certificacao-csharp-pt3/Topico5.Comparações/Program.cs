using System;
using System.Collections.Generic;
using System.Text;

namespace Topico5
{
    class Program
    {
        ///.Equals ou ==
        ///determina se a INSTANCIA do objeto, tem o mesmo tipo e valor
        ///Equals, compara tipo e valor
        ///== compara tipo, valor e a referencia da instancia
        

        static void Main(string[] args)
        {
            Console.WriteLine("Professor");

            ///outro exemplo
            Professor prof1 = new Professor() { Nome = "Maria de Souza" };
            Professor prof2 = new Professor() { Nome = "Maria de Souza" };

            ///essas comparações sempre serão false
            ///, por mais que os valores da propriedade seja identico, isso não importa pois os objetos são instancia diferentes
            Console.WriteLine(prof1.Equals(prof2));
            //usar ==, tbm serão false, pois alem de comparar os valores
            ///, as referencias os objetos apontam para instancia diferentes, areas da memoria são distintas
            Console.WriteLine(prof1 == prof2);
            



            Console.WriteLine("Aluno");

            Aluno aluno1 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno2 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            Aluno aluno3 = new Aluno
            {
                Nome = "josé da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));


            Aluno aluno4 = new Aluno()
            {
                Nome = "ANDRÉ DOS SANTOS",
                DataNascimento = new DateTime(1970, 1, 1)
            };

            Aluno aluno5 = new Aluno()
            {
                Nome = "Ana de Souza",
                DataNascimento = new DateTime(1990, 1, 1)
            };


            ///ordenação de lista .Sort

            List<Aluno> alunos = new List<Aluno>
            {
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5
            };

            ///utilizar para ordenar a lista, porém para realizar a chamada deste metodo
            ///sera necessario implementar na classe o metodo CompareTo, da interface IComparable
            alunos.Sort();

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadLine();
        }
    }

     class Professor
    {
        public string Nome { get; set; }
    }

    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data nascimento: {DataNascimento:dd/MM/yyyy}";
        }


        ///podemos criar o proprio comparador da classe, atraves do overrida do metodo Equals
        ///, assim podemos evitar a comparacao implicita por instanci
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            ///validamos o tipo
            if (outro == null)
                return false;

            ///validamos os valores
            return
                ///ignora o case sensitive
                this.Nome.Equals(outro.Nome, StringComparison.CurrentCultureIgnoreCase)
                &&
                this.DataNascimento.Equals(outro.DataNascimento);
        }

        ///aqui é preciso criar o metodo GetHashCode, pois gera um warning quando criamos um override do Equals
        ///esse metodos auxilia na localização, otimizando e facilitando a busca, e evitando perda de performance
        
        ///como gerar:
        ///criado de forma automatica, selecione as propriedades usados na comparacao
        ///clique com direito, e clique em Ações Rapidas
        ///clique em Gerar GetHashCode

        public override int GetHashCode()
        {
            var hashCode = -1523756618;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
            return hashCode;
        }



        ///implementaçao da interface IComparable
        ///aqui compara o objeto para verificar sua classificação/ordenação em uma lista
        ///compara o objeto atual com o anterior, para ordenar por data e depois nome

        ///se retorna 0 -> objetos são iguais
        ///se retorna > 0 -> objeto atual vai depois na ordenação
        ///se retorna < 0 -> objeto atual vai antes na ordenação
        
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1; //para ordenar no final da lista

            //obj é o objeto anterior
            //this é o objeto atual
            Aluno outro = obj as Aluno;

            if (outro == null)
                throw new ArgumentException("Objeto não é um aluno."); //não tem como ordenar um objeto nulo

            int resultado = this.DataNascimento.CompareTo(outro.DataNascimento); //compara se a data atual é maior, igual, ou menor que o anterior

            if (resultado == 0)//se as datas forem igual
                resultado = this.Nome.CompareTo(outro.Nome); //compara se o nome atual é vem depois, na msm posição ou antes do nome anterior

            return resultado;
        }
    }
}