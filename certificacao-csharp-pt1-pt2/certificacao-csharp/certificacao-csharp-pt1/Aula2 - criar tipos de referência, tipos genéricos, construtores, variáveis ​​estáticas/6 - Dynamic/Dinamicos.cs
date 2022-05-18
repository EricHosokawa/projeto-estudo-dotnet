using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            ///tipos dinamicos permitem trabalhar como um object dinamico que serao tratado e validados apenas em tempo de execucao
            ///em tempo de compilacao ele funciona como um object totalmente flexivel, podendo assumir qualquer operacao, tipo ou até mesmo classe
            
            dynamic dinamico = 1;
            dinamico = dinamico + 3;

            ///descomente e compile, o programa gera uma excecao de metodo nao implementado
            //dinamico.Teste();

            Console.WriteLine(dinamico);



            ///IMPORTANTE:
            ///o uso de dynamic roda na DLR (dynamic languade runtime), ou seja, sobre o CLR (commom language),
            ///permitindo assim criar linguagens e recursos dinamicas, ao C# (que é uma linguagem estatica)
            ///C# -> linguagem estatica, com alto nivel de programacao (codigo)
            ///DLR -> linguagem dinamica, com alto nivel de programacao (manipulacao de codigo + compilacao)
            ///CLR -> linguagem comum, de baixo nivel de programacao (execucao)
        }
    }
}
