using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {            
            ///os tipos de referencia sao alocados na memoria heap, ou seja a memoria é usada conforme a execucao do programa
            var cliente1 = new Cliente("José", 42);

            ///transformar struct numa class, faz com que as copias virem uma referencia da variavel original (exemplo abaixo)       
            ///necessario criar uma nova instancia da classe, para cada objeto que queira ser independente
            var cliente2 = cliente1;

            Console.WriteLine($"cliente1 : {cliente1}");
            Console.WriteLine($"cliente2 : {cliente2}");

            //alterando a original a copia tbm altera
            cliente1.Nome = "Maria";
            Console.WriteLine($"cliente1 : {cliente1}");
            Console.WriteLine($"cliente2 : {cliente2}");

            ///criar uma copia da variavel faz tanto a variavel original quanto a copia apontarem para a mesma area da memoria
            Console.WriteLine($"cliente1 == cliente2 {cliente1 == cliente2}");

            ///para confirmar essa teoria, criamos dois objetos identicos em duas instancias diferentes
            ///conclusao obvia que apontam para areas da memoria distintas
            Console.WriteLine($"cliente1 == cliente2 {new Cliente("Maria", 40) == new Cliente("Maria", 40)}");
        }

        class Cliente
        {
            public Cliente(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public string Nome { get; set; }
            public int Idade { get; set;  }

            public override string ToString()
            {
                return $"Nome: {Nome}, Idade: {Idade}";
            }
        }
    }
}
