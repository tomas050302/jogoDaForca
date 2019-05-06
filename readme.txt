Jogo da Forca: Jogo para 2 ou mais jogadores

Todas as partes essenciais do jogo funcionam, e estão todas organizadas em pequenas funções e procedimentos.
A escolha da opção desejada no menu é feita a partir das setas do teclado de modo a ser mais interativo com o utilizador.
Se a opção escolhida for a primeira, "Jogar", é escolhido um número à sorte a partir da clase Random. Esse número, depois de verificado que é um número impar (explicado mais à frente) e que é a primeira vez que está a surgir seleciona a linha que do tema que se encontrar no ficheiro "Temas.txt".
Depois de escolhido o tema é chamada a função EscritaPrimeiraInteracao que escreve todos os elementos necessários para o jogo mas que só são preciso de escrever uma única vez, como os traços com o nº de letras da palavra e o tema.
O número de traços da palavra têm em consideração os espaços que possam vir a ser introduzidos nas palavras.
Depois a cada interação do utilizador é apresentada uma mensagem ao utilizador para poder saber se a letra que introduzir existe na palavra ou não, se a letra não existir é chamada a função DesenharForca que, como o nome indica, desenha a forca.
À medida que o utlizador vai acertando palavras há uma variável que vai ser incrementada chamada "acertos" que vai ser mais tarde utilizada nos Logs (Logs.txt).
Quanto à segunda opção, a opção "Temas", esta tem várias funçoes como: adicionar novos temas e palavras, ver os que já estão introduzidos e dar um reset completo ao ficheiro.
As outras opções são apenas opções que mostram o conteúdo de ficheiros ou fazem funções simples que o próprio nome explica.
Todas as funções têm em conta quase todas as exceções possíveis como a de não existirem palavras no ficheiro, ou não existirem logs para mostrar.