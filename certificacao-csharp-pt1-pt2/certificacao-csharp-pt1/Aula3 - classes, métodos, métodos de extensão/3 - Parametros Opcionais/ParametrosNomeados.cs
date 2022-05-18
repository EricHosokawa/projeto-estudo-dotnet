using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            ///possivel realizar a chamada de metodo sem a necessidade de informar os parametros de forma ordenada/posicional
            ///basta informa o nome do parametro com :
            ImprimirDetalhesDoPedido(numeroPedido: 31, nomeProduto: "Caneca", vendedor: "Maria");
            ImprimirDetalhesDoPedido("Maria", nomeProduto: "Caneca", numeroPedido: 31);
        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio.", paramName: nameof(vendedor));
            }

            Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
