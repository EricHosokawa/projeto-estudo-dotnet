using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial();

            ///informando o valor para o parametro opcional
            clienteEspecial.FazerPedido(1, "residencia", 10);

            ///manter o valor default do parametro, nao informar o valor
            clienteEspecial.FazerPedido(3, "comercio");

            ///podem ser usados com os parametros nomeados
            clienteEspecial.FazerPedido(endereco: "residencia 2", produtoId: 3);
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;

        ///podemos manter o parametro como opcional no metodo construtor
        ///basta informar qual sera o valor default do parametro caso nao seja informado
        public ClienteEspecial(string nome = "anônimo")
        {
            this.nome = nome;
        }


        ///parametro opcional podem ser usados em qualquer metodo, basta apenas informar o valor default
        ///os opcionais devem ser colocados como ultimos parametros da assinatura do metodo
        public void FazerPedido(int produtoId, string endereco, int quantidade = 1)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
