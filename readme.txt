Jogo da Forca: Jogo para 2 ou mais jogadores

Todas as partes essenciais do jogo funcionam, e est�o todas organizadas em pequenas fun��es e procedimentos.
A escolha da op��o desejada no menu � feita a partir das setas do teclado de modo a ser mais interativo com o utilizador.
Se a op��o escolhida for a primeira, "Jogar", � escolhido um n�mero � sorte a partir da clase Random. Esse n�mero, depois de verificado que � um n�mero impar (explicado mais � frente) e que � a primeira vez que est� a surgir seleciona a linha que do tema que se encontrar no ficheiro "Temas.txt".
Depois de escolhido o tema � chamada a fun��o EscritaPrimeiraInteracao que escreve todos os elementos necess�rios para o jogo mas que s� s�o preciso de escrever uma �nica vez, como os tra�os com o n� de letras da palavra e o tema.
O n�mero de tra�os da palavra t�m em considera��o os espa�os que possam vir a ser introduzidos nas palavras.
Depois a cada intera��o do utilizador � apresentada uma mensagem ao utilizador para poder saber se a letra que introduzir existe na palavra ou n�o, se a letra n�o existir � chamada a fun��o DesenharForca que, como o nome indica, desenha a forca.
� medida que o utlizador vai acertando palavras h� uma vari�vel que vai ser incrementada chamada "acertos" que vai ser mais tarde utilizada nos Logs (Logs.txt).
Quanto � segunda op��o, a op��o "Temas", esta tem v�rias fun�oes como: adicionar novos temas e palavras, ver os que j� est�o introduzidos e dar um reset completo ao ficheiro.
As outras op��es s�o apenas op��es que mostram o conte�do de ficheiros ou fazem fun��es simples que o pr�prio nome explica.
Todas as fun��es t�m em conta quase todas as exce��es poss�veis como a de n�o existirem palavras no ficheiro, ou n�o existirem logs para mostrar.