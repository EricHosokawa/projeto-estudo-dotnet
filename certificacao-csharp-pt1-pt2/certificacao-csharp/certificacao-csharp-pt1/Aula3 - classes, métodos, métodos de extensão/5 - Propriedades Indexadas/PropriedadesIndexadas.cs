using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();

            ///a propriedade pode ser utilizada como index do dicionario
            sala["D01"] = new ClienteCinema("Maria de Souza");
            sala["D02"] = new ClienteCinema("José da Silva");

            sala.ImprimirReservas();
        }
    }

    class ClienteCinema
    {
        public ClienteCinema(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }

    class Sala
    {
        private readonly IDictionary<string, ClienteCinema> reservas = new Dictionary<string, ClienteCinema>();

        ///propriedades indexadas para as 'reservas'
        ///aqui a propriedade da 'reservas' sera indexada pelo codigo do assento informado na chamada da prop
        
        ///regras gerais:
        ///nao precisa informar o nome da propriedade
        ///usar o this no lugar do nome da propriedade
        ///alem de usar o [] contendo o "parametro" de indexacao
        ///'resevas' esta implicito como o valor da propriedade a ser atribuida, pois esta contido no get e set
        public ClienteCinema this[string codigoAssento]
        {
            get
            {
                return reservas[codigoAssento];
            }

            set
            {
                reservas[codigoAssento] = value;
            }
        }

        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos Reservados");
            Console.WriteLine("===================");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} - {reserva.Value}");
            }
        }
    }
}
