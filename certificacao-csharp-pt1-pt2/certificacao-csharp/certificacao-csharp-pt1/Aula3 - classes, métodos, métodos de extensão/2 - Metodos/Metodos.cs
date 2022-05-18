using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Metodos : IAulaItem
    {
        ///metodos separam os blocos de codigos possibilitando sua chamada em varias partes do codigo, ou ate mesmo de outras classes
        ///evitar redundancia de codigo

        ///modificadores - ver a aula sobre classes


        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);
            Console.WriteLine($"area : {retangulo.GetArea()}");

            Retangulo outroRetangulo = new Retangulo(10, 10);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura));

            ///aq a sobrecarga do metodo pode ser usada quando existirem metodos semelhantes porem com as assinaturas distintas
            Retangulo outroRetangulo2 = new Retangulo(12, 10);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo2));

            ///aq outra sobrecarga de metodo
            Retangulo outroRetangulo3 = new Retangulo(8, 10);
            Console.WriteLine(Retangulo.Semelhante(retangulo, outroRetangulo3));
        }
    }

    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        ///construtor = metodo inicializador da classe ao ser instanciada    
        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura}, largura: {largura}");
        }

        public double GetArea()
        {
            return Altura * Largura;
        }



        ///uso do modificador internal para o metodo ser acessivel apenas a este projeto
        internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetanguloLargura / outroRetanguloAltura));
        }

        ///uso do modificador public para o metodo ser acessivel a todas as outras classes e projetos
        public bool Semelhante(Retangulo outroRetangulo)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetangulo.Largura / outroRetangulo.Altura));
        }

        ///uso do modificador internal para o metodo ser acessivel apenas a este projeto, porem a partir da propria classe, nao mais da instancia
        internal static bool Semelhante(Retangulo retangulo, Retangulo outroRetangulo)
        {
            return
                ((retangulo.Largura / retangulo.Altura) == /*proporção deste retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura)) /*proporção do outro retângulo*/
                ||
                ((retangulo.Altura / retangulo.Largura) == /*compara a proporção inversa*/
                (outroRetangulo.Largura / outroRetangulo.Altura));
        }
    }
}
