# OPERADORES E EXPRESS�ES

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img1.png)

O bom entendimento das **express�es** � fundamental n�o s� para cria��o de de condi��es com **if**, mas outras constru��es de decis�es, como as instru��es **switch-case, while e do while**, que veremos mais adiante no curso.

Diferente de outras linguagens, na linguagem C# a express�o da condi��o **if** sempre deve retornar um booleano. Portanto, a express�o abaixo � inv�lida e gera um erro de compila��o:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img2.png)

##### OPERADORES RELACIONAIS

Um operador relacional ir� comparar dois operandos (por exemplo, duas vari�veis) e retornar um valor booleano com o resultado da compara��o.

Podemos comparar a igualdade, por exemplo:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img3.png)

Mas note que o os operadores de igualdade podem ter significado diferente, dependendo do tipo de dado: Se o tipo for **tipo de valor** (inteiro, booleano, char), ent�o a igualdade se dar� pelo valor. Se o tipo for **tipo de refer�ncia**, ent�o duas inst�ncias diferentes ser�o comparadas em sua identidade como **diferentes**, mesmo que contenham os mesmos valores.

Os valores num�ricos podem ter suas grandezas comparadas com operadores **maior e menor**.

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img4.png)

Voc� pode ainda testar o **tipo do dado**, para saber n�o apenas de um tipo espec�fico mas tamb�m **se ele pode ser convertido** para um tipo mais b�sico (gen�rico), como uma classe base ou interface.

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img5.png)

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img6.png)

##### OPERADOR NOT
 
Muitas vezes � necess�rio testar n�o se uma condi��o � verdadeira, **mas se ela � falsa**. Para isso, usamos o **OPERADOR NOT (!)**:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img7.png)

E se tivermos tamb�m uma instru��o **else**? Nesse caso, temos que inverter a ordem dos blocos **then** e **else** que seriam usados caso a express�o fosse verdadeira, para que o programa fique correto:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img8.png)

##### OPERADORES L�GICOS: O OPERADOR �AND� (&&)

Vamos dar uma olhada no operador de compara��o simples, **�maior ou igual�**:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img9.png)

No exame 70-483, voc� ter� que lidar com express�es mais complexas do que essa, que envolvem combina��es de express�es mais simples. Por exemplo:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img10.png)

Como podemos interpretar essa express�o? 

**�Se m1 for maior ou igual a n1 E 
m1 for maior ou igual a p1�**

O operador AND (&&) combina 2 express�es menores em uma express�o maior, e s� retorna verdadeiro se as duas express�es-filhas forem **verdadeiras**.

Mas vamos ver como o runtime do .NET interpreta essa express�o como express�es menores:

1) Primeiro, o *runtime* avalia a **primeira express�o**, em destaque:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img11.png)

1.1) Se a express�o for **falsa**, a express�o retorna **falso**, sem que a segunda express�o seja avaliada.

1.2) Se a express�o for **verdadeira**, o runtime do .NET ir� avaliar a segunda express�o.

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img12.png)

1.3) O operador AND (&&) s� retorna verdadeiro se as duas express�es-filhas forem **verdadeiras**

Note que, se a primeira express�o for **falsa**, a segunda express�o nem � avaliada. Essa caracter�stica se chama **curto-circuito do operador AND**.

##### OPERADORES L�GICOS: O OPERADOR �OR� ( || )

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img13.png)

Como podemos interpretar essa express�o? 

**�Se m1 for maior que n1 OU 
m1 for maior que p1�**

O operador OR ( || ) combina 2 express�es menores em uma express�o maior, e s� retorna verdadeiro se **pelo menos uma** das duas express�es-filhas for **verdadeira**.

Mas vamos ver como o runtime do .NET interpreta essa express�o como express�es menores:

1) Primeiro, o *runtime* avalia a **primeira express�o**, em destaque:

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img14.png)

1.1) Se a express�o for **verdadeira**, a express�o retorna **verdadeiro**, sem que a segunda express�o seja avaliada.

1.2) Se a express�o for **falsa**, o *runtime* do .NET ir� avaliar a segunda express�o.

![](https://raw.githubusercontent.com/alura-cursos/certificacao-csharp-pt4/master/Imagens/01.operadores-expressoes/img15.png)

1.3) O operador OR ( || ) s� retorna verdadeiro se **pelo menos uma** das duas express�es-filhas for **verdadeira**

Note que, se a primeira express�o for **verdadeira**, a segunda express�o nem � avaliada. Essa caracter�stica se chama **curto-circuito do operador OR**.

##### PARA SABER MAIS

***Consulte a documenta��o da Microsoft sobre operadores C#:***
https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/index



