using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            ///declarando variaveis - que sao definidos em tempo de compilação

            ///atribuir valores de string as variaveis, note q todas aceitam sem necessidade de conversao
            string s = "Certificação C#";
            var v = "Certificação C#"; ///não necessidade de informar o tipo, ele se resolver pelo tipo que esta sendo atribuido
            object o = "Certificação C#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);


            ///usar o metodo do toupper para deixa todos os caracteres maiusculos
            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper(); //nesse caso como é um object, deve-se realizar o cast

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);


            ////atribuir outros valores diferentes de string, no caso numero
            //s = 123; //impossivel, mesmo com caste
            //v = 123; //impossivel mesmo com cast
            o = 123; //possivel por ser um object
            o = (int)o + 4; //porem como visto anteriormente, caso necessite usar o tipo especifico, sera necessario realizar o cast
            Console.WriteLine(o);





            ///declarando variaveis - que sao definidos em tempo de execução

            ///usando o dynamic, atribuindo um string, sem necessidade de conversao
            dynamic d = "Certificação C#";
            Console.WriteLine(d);

            ///podemos utilizar os metodos auxiliares do tipo q esta implicito, mesmo q não apareca no .net
            d = d.ToUpper(); //aq ele se resolve em tempo de execucao, por isso nao dá erro
            Console.WriteLine(d);

            ///ao atribuir um outro tipo ele tbm aceita, sem necessidade conversao
            d = 123; //antes era um string, e deixou armazenar um numero
            Console.WriteLine(d);

            ///podemos usar até operadores matematicos, sem necessidade conversao
            d = d + 4; //aq ele se resolve tbm em tempo de execucao, sem erros
            Console.WriteLine(d);
        }
    }
}
