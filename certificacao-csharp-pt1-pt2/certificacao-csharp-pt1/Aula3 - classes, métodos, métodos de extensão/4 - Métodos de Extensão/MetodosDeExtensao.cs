using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosDeExtensao : IAulaItem
    {
        ///uso de extensoes para quando houver classes com os codigo inacessivel, mas que sera necessario inclusao de novos metodos

        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.ImprimirDocumento();

            ///chamada do metodo extendido nao precisa passar o parametro, pois esta explicito a palavra reserva this no parametro do metodo
            impressora.ImprimirDocumentoHTML();
        }        
    }

    class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
    }


    ///classe extensora da classe base (Impressora)
    
    ///regras gerais:
    ///1 extensoes necessariamente devem ser publicos e estaticos
    ///2 informar no argumento do metodo a classe que sera extendida
    ///3 usar a palavra reservada this no parametro do metodo
    static class ImpressoraExtensions
    {
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }
}


