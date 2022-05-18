using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            ///sobreposicao/substituicao dos metodos beber, comer e andar
            ///possibilita a substituicao ou sobreposicao dos metodos de uma classe derivada, em relacao aos metodos da classe base

            ///regras gerias:
            ///usamos entao a substituicao ou sobreposicao de metodos, com o modificador virtual nos metodos da classe base
            ///e usando override nos metodos da classe derivada
            
            ///assim o .net sempre priorizara a palavra chave override
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();
        }
    }

    public interface IAnimal
    {
        string Nome { get; set; }

        void Andar();
        void Beber();
        void Comer();
    }

    class Animal : IAnimal
    {
        public String Nome { get; set; }

        ///aq usamos o virtual, pois estamos na classe base

        public virtual void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }

        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }

        public virtual void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }

    class Gato : Animal
    {
        ///aq usamos o override, pois estamos na classe derivada

        public override void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }

        public override void Comer()
        {
            Console.WriteLine("Gato.Comer");
        }

        public override void Andar()
        {
            Console.WriteLine("Gato.Andar");
        }
    }
}