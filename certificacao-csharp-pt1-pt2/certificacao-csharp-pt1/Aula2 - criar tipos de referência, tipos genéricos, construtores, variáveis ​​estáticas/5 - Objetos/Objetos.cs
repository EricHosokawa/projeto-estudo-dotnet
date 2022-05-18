using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;

            Console.WriteLine("Objeto com valor PRIMITIVO");

            ///o object é o tipo mais basico do .net, todos os outros tipos derivam deste tipo
            ///assim pode comportar qualquer tipo dentro do c#, ate mesmo classes
            ///porem apenas em tempo de compilacao e execucao....nao em tempo de codificacao

            object meuObjeto;
            meuObjeto = pontuacao;

            Console.WriteLine($"meuObjeto : {meuObjeto}");

            ///para os tipo primitivos, herda o tipo do valor atribuido em tempo de execucao e sem a necessidade tipar/converter
            ///nesse caso o int
            ///conversao implicita, .net converte de forma automatica para tipos primitivos
            Console.WriteLine($"o tipo é {meuObjeto.GetType()}");


            Console.WriteLine("Objeto com REFERENCIA de objeto");

            meuObjeto = new Jogador();
            Jogador classRef;
            
            ///em tipo de referencia, é necessario informar o nome do tipo para conversao
            ///conversao explicita (cast), necessario fazer a conversao para o tipo, no codigo
            classRef = (Jogador)meuObjeto;

            Console.WriteLine($"pontuacao : {classRef.Pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
