### COMPILA��O CONDICIONAL

At� agora, vimos como utilizar condi��es para definir fluxos alternativos de uma aplica��o. Essas condi��es s�o avaliadas **em tempo de execu��o**, pelo Runtime do .NET Framework/.NET Core.

O que vamos ver agora � uma categoria especial de condi��es da linguagem C#, que n�o s�o usadas durante o tempo de execu��o, mas para definir **qual c�digo** deve ser inclu�do nos pacotes (assemblies) da sua aplica��o, durante o **tempo de compila��o** do aplicativo.

No exame 70-483, voc� poder� encontrar algumas quest�es com esses casos especiais de condi��es. Essas quest�es ir�o apresentar problemas chamados de **compila��o condicional**.

##### #if, #else, #elif, #endif

Vamos come�ar com um programa bem simples, que imprime no console uma mensagem indicando se o programa foi compilado com modo **debug** ou modo **release**:

![](https://lh4.googleusercontent.com/10uDKltn-wnndcqGERED4ljsEADukP1dZsl20MVNyn7Gc-Z8lgkAYyoPGRoCMhFa16dl5BWvCCtRLBbI546dGnZdATl2NNoQFkxQsLhSt1SAvd18V81rQ3MdlfnZmtuxd5J2mGWV)

Note que estamos usando uma constante **DEBUG** para indicar que o modo de compila��o � **debug**.

Se voc� precisar compilar o c�digo em release, basta mudar o valor da constante **DEBUG** para **false**.

![](https://lh5.googleusercontent.com/I3Sr2Vs1FU-z2pk-X8nqRCHcJPrON1fPjtzr61on-hk0_ISL0qEc4OXNGM7wb8vmBDzKaVn6onXwOVOKVmh0S7aXsgTKwzM_KNs-Plo-EYgerybX9v33pF0DUSb06Uh-GhZv3zgy)

Mas existe um problema aqui: sempre que formos mudar o modo de compila��o, precisamos mexer no valor da constante. Seria melhor fazer isso automaticamente, detectando o modo de compila��o sem precisar usar uma constante.

Vamos fazer algumas altera��es para permitir a detec��o do modo de compila��o:

1.  vamos comentar a constante **DEBUG** no nosso c�digo

2.  vamos adicionar um s�mbolo hash "#" antes do **if** e do **else**

3.  vamos adicionar uma instru��o #**endif** ao final do **if**

![](https://lh3.googleusercontent.com/9bHj-e9_jF008sS6OLKUl8dM3jFy0UlTl9epf2S17xwUWoh_XXxMbETc9uRBb77IvVco5fU_d9lbPYW8D3Gw4ilkEmHIKoVm4kOABGhLKQAXnu8xSM4GEUjOEHyxDIJSAi7AEDff)

O que aconteceu aqui? qual a diferen�a entre um **if e else** e um #**if** e #**else**?

-   if e else definem o fluxo da aplica��o em **tempo de execu��o**

-   #if, #else e #endif definem **quais trechos de c�digo** devem ser inclu�dos na compila��o

Mas se comentamos a constante **DEBUG** no nosso c�digo, como conseguimos compilar sem erro?

Vamos descobrir isso entrando nas propriedades do projeto (teclando ALT+ENTER):

![](https://lh6.googleusercontent.com/oPwdHpRtGrvd3RE1Opafvd6Em6kVLEa4pICIdqielsn3k0rlxbw4uAccPT2aykvu5oJUwcwYvCk2U7-kcw9bSYI1AJkjkusQ13OL098I9X_D5VXGHZcNEmwGC5OCeYn4tSW5syCO)

Entramos agora na guia Build:

![](https://lh5.googleusercontent.com/nVdoI2KyROLDB8WTN-mflh2dClZk0LQ1C2w03GCK3AqK0Jcpdo1VY2Tbhch07py8l2mh-g9JqX-AGgduemXCCFMrkdSG9mBlX9qApfqOuKJ4w-Qo1UwLhoTQtGq8nrCOOYv2bXti)

L� dentro da p�gina de propriedades, veremos uma configura��o indicando uma **constante de compila��o** que � adicionada ao programa automaticamente:

![](https://lh6.googleusercontent.com/bF7NAX_-aosOauWDKBxMhpRo0wxI8EBifRISfah4Q1K73XZjX6mgwg4H4VPHp5g3J5aDlU8Yjn4ZXuMGq6DrEup8XjPfd_vyPChUcEGfB7G7Xq9Ny4GYGEIjOz7LsqTJX2RKuASY)

Como podemos ver, o projeto est� configurado para **definir uma constante chamada DEBUG**. Note que essa constante � um **s�mbolo de compila��o**, que n�o est� dispon�vel para o runtime  do .NET, mas apenas para o compilador C#. � importante notar que if � uma **instru��o**, enquanto #if e #endif s�o **diretivas**, isto �, apenas delimitam trechos de c�digo que podem ou n�o serem inclu�dos na compila��o.

De forma similar, se voc� mudar a compila��o para Release, uma outra constante, **RELEASE**, ser� inclu�da no lugar de **DEBUG**.

Para demonstrar como o compilador do C# compila esse c�digo, vamos adicionar esse c�digo no site **sharplab.io**:

<https://sharplab.io/#v2:CYLg1APgrgzglgOwOYAIDKBPGAXApgWwG4BYAKAAcoAjAGzgGMV6aBDGGFAWUQAsWBhVu1xkA3mRSSUlWgxQA3APZxgXXFE65si4IoAUASglTxpKeZQBiOADMUegCIBRAEIBVAOJGzF3/0UIMIo0uAB0AOoATnB4ADKIuHoARABquJEwAMeKKM7uHkkGJD6+lrg0MCIlvlL+gcFhUTG48QiJqelZOQBKTrFOAIJoToXFNVa4CMC2xpIAvmQLpGRAA===>

![](https://lh5.googleusercontent.com/DBU8SDVwLJTivQIYN_Se08EnSjj7KCLdbrh4_Q_Hz0sdj_CXxT-geMsitE2A4QkpcLZy5qQxo92gYO0eMNKBsTqvW3ytxgbC_x6k7M7ci6qN3LTO0atAuK5JkeW7ADyHjJQ75Mfg)

Agora veja na aba da direita, como o compilador incluiu somente a primeira instru��o `Console.WriteLine`:

![](https://lh6.googleusercontent.com/qSOjEgIPOWSF6j4B7xlq_2U-lziHwbSEYANkwZMK9L2W3GIbgD9z47xBPygz_m9pOHOEelqdIPm3R0dSiEdTww7eFZFKNPsa0PZvwwFn2xY4yZPtDTS2rzMe8ONjitn9zihp0-RN)

Na mesma p�gina, vamos mudar o modo de compila��o para Release:

![](https://lh6.googleusercontent.com/2y2xH0kGWU2eqevLo2VdZyz3H_fMudd-UfPoA9Iq_ysVTlYLk8oCk_3VlQuUQqo18jz6wvqqsX5IxMmund9geHxfNG3uOBRhJXaTwSN_9Fd9h2hWgulzpIdpEEFkTmXQcUpYzuz6)

Automaticamente o c�digo gerado muda para incluir somente a segunda instru��o `Console.WriteLine("Vers�o RELEASE");`:

![](https://lh6.googleusercontent.com/oauzKhFVO6xKfFieBZ0Zdw6elj_ytdiMDcnWyUjg5woMuH0PLVGjeZ14OCExKdAV4UBaOVnoA8CAUE9xN4pPMgvuIeo0hqvzmE_mksCXzZostPE2gZgzdAgC-H6Mszl873nFYgsZ)

Mas voc� pode estar se perguntando: **por que usar compila��o condicional**?

Por v�rios motivos. Voc� pode, por exemplo, querer gerar logs em arquivos ou banco de dados em seu **ambiente de testes** (com op��o de DEBUG), para diagnosticar poss�veis problemas com o c�digo ou com a infraestrutura. Mas ao mesmo tempo em que esses logs s�o �teis em testes, eles acabam **afetando a performance** da aplica��o. Por isso, voc� n�o quer que esse c�digo n�o seja enviado para o ambiente de produ��o, onde o c�digo � compilado com modo **RELEASE**. Esse � s� um dos motivos para querermos usar compila��o condicional.