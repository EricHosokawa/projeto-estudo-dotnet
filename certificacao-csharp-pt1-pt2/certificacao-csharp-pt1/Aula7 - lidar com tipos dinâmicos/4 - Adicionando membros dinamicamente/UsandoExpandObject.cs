
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            ///tipo ExpandoObject, criar objetos dinamicamente, sem a necessidade de criar classes e instancias


            string json = "{\"De\": \"Paulo Silveira\"," +
                "\"Para\": \"Guilherme Silveira\"}";

            ///nesse exemplo usamos o tipo EO, para receber uma conversao de uma mensagem json
            ///necessario que o tipo que recebe o EO seja um dynamic
            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            ///como é um dynamic, podemos criar novas propriedades
            mensagem.Texto = "Olá, "  + mensagem.Para;

            EnviarMensagem(mensagem);

            ///podemos tbm criar metodos anonimos de forma dinamica
            mensagem.Inverter = new Action(() => 
                {
                    ///esse exemplo de metodo que troca o De para o Para
                    var aux = mensagem.De;
                    mensagem.De = mensagem.Para;
                    mensagem.Para = aux;
                    mensagem.Texto = "Olá, " + mensagem.Para + ", recebi sua mensagem.";
                });

            ///chamano o metodo anonimo criado dinamicamente
            mensagem.Inverter();

            EnviarMensagem(mensagem);



            //podemos objetos dinamicos apenas instanciando o EO
            mensagem = new ExpandoObject();
            mensagem.De = "Paulo Silveira";
            mensagem.Para = "Guilherme Silveira";
            mensagem.Texto = "Olá, " + mensagem.Para;
            EnviarMensagem(mensagem);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }
}
