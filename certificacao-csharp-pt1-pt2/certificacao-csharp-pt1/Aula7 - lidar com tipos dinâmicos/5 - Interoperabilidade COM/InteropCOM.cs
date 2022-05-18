using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class InteropCOM : IAulaItem
    {
        public void Executar()
        {
            ///Interoperabilidade COM (COMPONENT OBJECT MODEL)
            ///usado para acessar e manipular bibliotecas que usam outras tecnologias, como o C++ por exemplo


            ///podemos resgatar/obter o tipo que precisamos, nesse caso um tipo Excel.Application
            ///obs: o componente a ser obtido deve estar na maquina em que o programa executa
            Type excelType = Type.GetTypeFromProgID("Excel.Application", true);

            ///podemos criar uma nova instancia o tipo obtido
            dynamic excel = Activator.CreateInstance(excelType);

            ///podemos alterar algumas das propriedades do componente, desde que saibamos quais propriedades são
            excel.Visible = true;

            ///podemos chamar um metodo do componente, desde que saibamos quais metodos são
            excel.Workbooks.Add(); ///esse metodo cria uma nova pasta de trabalho para a planilha

            ///podemos atribuir a propriedade, a um outra variavel
            dynamic planilha = excel.ActiveSheet; ///atribui a planilha q esta ativa

            ///atribui os dados na planilha ativa, obtida na propriedade
            planilha.Cells[1, "A"] = "Alura";
            planilha.Cells[1, "B"] = "Cursos";
            planilha.Cells[2, "A"] = "Certificação";
            planilha.Cells[2, "B"] = "C#";
            planilha.Columns[1].AutoFit();
            planilha.Columns[2].AutoFit();
        }
    }
}

