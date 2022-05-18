using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            ///descomente este bloco de codigo, e comente o bloco de baixo para usar o is
            ///operador is, verifica se tipos sao iguais, e pode tbm atribuir a uma variavel criada dinamicamente
            if (obj is Animal animal)  ///variavel animal nao precisa ser declarada
            {
                animal.Beber();
                animal.Comer();
                return;
            }

            Console.WriteLine("obj não é um animal.");




            ///descomente este bloco de codigo, e comente o bloco de cima para usar o as
            ///operador as, realiza a conversao com seguranca, se o obj for de um tipo diferente ele mantem nulo
            //Animal animal = obj as Animal;

            //if(animal == null)
            //{
            //    Console.WriteLine("obj não é um animal.");
            //    return;
            //}
            //animal.Beber();
            //animal.Comer();
        }
    }

    internal class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
