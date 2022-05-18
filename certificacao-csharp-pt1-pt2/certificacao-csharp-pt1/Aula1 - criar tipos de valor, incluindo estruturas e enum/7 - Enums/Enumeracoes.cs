using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            Semanas primeiro = Semanas.Seg;
            Semanas segter = Semanas.Seg | Semanas.Ter;

            Console.WriteLine($"primeiro dia é {primeiro}");
            Console.WriteLine(segter);

            EstadoCivil estadoCivil = EstadoCivil.Casado;
            Console.WriteLine($"Sou {estadoCivil}");
        }
    }

    ///enum alias do System.Enum
    ///numerar, nomear, são constantes, tipos e estaticos, e nao precisa instanciar
    ///numericamente o primeiro valor sempre sera 0, e segue a ordem crescente, a menos que a numeracao tbm sera tipada
   
    [Flags]
    enum Semanas { Seg = 1, Ter = 2, Qua = 4, Qui = 8, Sex = 16, Sab = 32, Dom = 64 }

    enum EstadoCivil { Solteiro, Casado, Viuvo, Separado }
}
