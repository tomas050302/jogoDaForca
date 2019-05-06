using System;
using System.IO;

/*
 *                   Trabalho Jogo da Forca 09/01/2019 Tomás Lopes
 * */

// O TOMÁS É GAY
namespace Jogo {
    public static class Program {
        private static void DesenharForca(int erros, int pos) {
            int posinicio = pos + 12;  //pos inicio para variar a localizacao da forca conforme o tamanho da palvra            

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posinicio, 6);
            switch (erros) {
                case 1:
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---");
                    break;
                case 2:
                    Console.SetCursorPosition(posinicio, 7);
                    Console.Write(" |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.Write(" |");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.Write(" |");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.Write(" |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.Write("---");
                    break;
                case 3:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---");
                    break;
                case 4:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---");
                    break;
                case 5:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |     O");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---");
                    break;
                case 6:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |     O");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---");
                    break;
                case 7:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |     O");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(" |    /|");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---");
                    break;
                case 8:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |     O");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(@" |    /|\");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---");
                    break;
                case 9:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |     O");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(@" |    /|\");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine("---    /");
                    break;
                case 10:
                    Console.WriteLine(" -------");
                    Console.SetCursorPosition(posinicio, 7);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 8);
                    Console.WriteLine(" |     O");
                    Console.SetCursorPosition(posinicio, 9);
                    Console.WriteLine(@" |    /|\");
                    Console.SetCursorPosition(posinicio, 10);
                    Console.WriteLine(" |     |");
                    Console.SetCursorPosition(posinicio, 11);
                    Console.WriteLine(@"---    /\");
                    break;
            }
        }

        private static void Menu() {
            Console.WriteLine("MENU\n");
            Console.Write("  Jogar");
            Console.Write("  Resetar Logs".PadLeft(30));
            Console.Write("\n\n  Editar Temas");
            Console.Write("  Leaderboard".PadLeft(22));
            Console.Write("\n\n  Ver Logs");
            Console.Write("  Sair e Guardar".PadLeft(29));
        }

        private static byte Nav() {
            byte op = 1;
            ConsoleKeyInfo key;
            byte j = 2; //so tem valores positivos
            int i = 0;
            Console.CursorVisible = false;
            Menu();
            do {
                Console.SetCursorPosition(i, j);
                Console.Write("»");
                key = Console.ReadKey(true); //para nao deixar no ecra a tecla premida 
                Console.Write("\b \b"); //para limpar a tecla antes premida
                switch (key.Key) {
                    case ConsoleKey.UpArrow:
                        j -= 2;
                        if (j >= 1) {
                            op--;
                        } else { //se exceder os limites repoe o valor de i                        
                            j += 2;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        j += 2;
                        if (j <= 7) {
                            op++;
                        } else {
                            j -= 2;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        i += 23;
                        if (i <= 23) {
                            op += 3;
                        } else {
                            i -= 23;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        i -= 23;
                        if (i >= 0) {
                            op -= 3;
                        } else {
                            i += 23;
                        }
                        break;
                    default:
                        break;
                }
                Console.SetCursorPosition(i, j);
                Console.Write("»");
                //Console.WriteLine(op);
            } while (key.Key != ConsoleKey.Enter);
            Console.CursorVisible = false;

            return op;
        }

        private static void Logs(string dirlogs) {
            bool primeira = false; //variavel para verficar se entra no ciclo pelo menos uma vez
            string linha;
            StreamReader sr = new StreamReader(dirlogs);

            while ((linha = sr.ReadLine()) != null) {
                primeira = true;
                Console.WriteLine(linha);
            }
            if (primeira == false) { //se nao tiver entrado no ciclo então todas as linhas estao em branco
                Console.Write("Não existem sessões gravadas nos logs.");
            }
            sr.Close();
        }

        private static void Reset(string dirlogs) {
            File.WriteAllText(dirlogs, string.Empty);
            Console.Clear();
            Console.WriteLine("Todos os Logs foram resetados");
        }

        private static void Temas(string dirtemas) {
            string linha, res;
            Console.Clear();

            Console.WriteLine("Deseja ver os temas existentes ou adicionar novos?");
            Console.WriteLine("'v' para ver, 'a' para adicionar ou 'r' para dar reset a todos os temas");
            Console.Write("Opção: ");
            res = Convert.ToString(Console.ReadKey().Key).ToLower();

            if (res == "v") {
                Console.Clear();
                FileStream fs = new FileStream(dirtemas, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                if (sr.ReadToEnd().Length == 0) {
                    Console.WriteLine("Não existem temas, adicione alguns!");
                    Console.ReadKey();
                } else {
                    FileStream fss = new FileStream(dirtemas, FileMode.Open, FileAccess.Read); //para voltar ao inicio do ficheiro
                    StreamReader srr = new StreamReader(fss);
                    while ((linha = srr.ReadLine()) != null) {
                        Console.WriteLine(linha);
                    }
                    Console.ReadKey();
                    srr.Close();
                }
                sr.Close();
            } else if (res == "a") {
                StreamWriter sw = new StreamWriter(dirtemas, true);

                Console.Clear();
                Console.WriteLine("Alguns temas sugeridos: "); //Colocar aqui mais temas
                Console.WriteLine("Natureza");
                Console.WriteLine("Desporto");
                Console.WriteLine("Informática\n");
                Console.WriteLine("NOTA: Todos os espaços vão ser substituídos por hifens.");
                Console.Write("Quando desejar parar a introdução de palavras insira um ESPAÇO");
                string tema = null;
                ConsoleKeyInfo key;
                do { //ciclo infinito que acaba com os breaks
                    string palavra = null;
                    Console.Write("\nInsira o tema da palavra: ");
                    tema = Console.ReadLine().ToLower();
                    if (tema == " ") {
                        break;
                    } else if (tema.Length > 50) {
                        Console.WriteLine("O tema excede o número de letras permitido");
                        break;
                    }
                    Console.Write("Insira a palavra: ");
                    do {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Backspace) {
                            if (Console.CursorLeft > 18) {
                                Console.Write("\b \b");
                                palavra = palavra.Remove(palavra.Length - 1);
                            }
                        } else if (key.Key != ConsoleKey.Enter) {
                            Console.Write("*");
                            palavra += key.KeyChar;
                        }
                    } while (key.Key != ConsoleKey.Enter);
                    if (palavra == " ") {
                        break;
                    } else if (palavra.Length > 50) {
                        Console.WriteLine("A palavra excede o número de letras permitido");
                        break;
                    } else {
                        sw.WriteLine(tema.Trim()); //Linhas impares vão ser temas
                        sw.WriteLine(palavra.ToLower().Trim()); //Linhas pares vão ser palavras
                    }
                } while (true);
                sw.Close();
            } else if (res == "r") {
                Console.Clear();
                File.WriteAllText(dirtemas, string.Empty);
                Console.WriteLine("Todos os temas foram resetados");
                Console.ReadKey();
            } else {
                Console.WriteLine("Resposta Inválida");
            }
        }

        private static string PickTema(ref string palavra, string dirtemas, ref int[] repetidos) {
            int i = 0, n = 0;
            bool val;
            int reps = 0;
            string[] linhas = File.ReadAllLines(dirtemas);

            FileStream fs = new FileStream(dirtemas, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            i = linhas.Length;
            sr.Close();
            //Console.WriteLine(i);
            Random rnd = new Random();

            do {
                val = true;
                do {
                    n = rnd.Next(0, i);
                } while (n % 2 != 1); //Para ter a certeza que é uma linha impar, ou seja, um tema 

                foreach (int element in repetidos) {
                    if (reps > repetidos.Length + 1) { //para acabar o ciclo infinito 
                        bool validade = false; //variavel para saber se foi inserida uma resposta válida
                        do {
                            Console.Clear();
                            Console.Write("Acabaram os temas deseja repetir os temas já jogados? (S/N) ");
                            var res = Console.ReadKey();
                            switch (Convert.ToString(res.Key).ToUpper()) {
                                case "S":
                                    Array.Resize(ref repetidos, 1);
                                    repetidos[0] = 0;
                                    validade = true;
                                    break;
                                case "N":
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("\nReposta Inválida");
                                    Console.ReadKey();
                                    break;
                            }
                            val = true;
                            return null;
                        } while (!validade);
                    } else if (n == element && repetidos[0] != 0) {
                        val = false;
                        reps++;
                    } else if (repetidos[0] == 0) {
                        //exceção da primeira ocorrencia em que não é preciso o resize                        
                        repetidos[0] = n;
                    }
                }
            } while (!val);

            Array.Resize(ref repetidos, repetidos.Length + 1);
            repetidos[repetidos.Length - 1] = n;

            //Console.WriteLine(n);             
            string tema = linhas[n - 1];
            palavra = linhas[n];
            return tema;
        }

        private static void Output(string palavra, string tema, ref int acertos) {
            int certas = 0, pos;
            char[] erradas = new char[0];
            char[] existentes = new char[0];
            byte j = 0;

            try {
                palavra.Substring(1); //ver se a palavra tem conteudo
            } catch (Exception) {
                Console.WriteLine("Não existem temas para jogar.");
                throw;
            }
            Console.Clear();
            byte espacos = 0;
            pos = EscritaInicio(palavra, tema, ref espacos);
            int posfin = 5 + 6 + tema.Length + 15; // espaço da direita + espaço tema + 7 espaços

            do {
                EscritaCadaInteracao(ref erradas, palavra, ref certas, ref j, ref existentes, pos, posfin);
            } while (j <= 9 && certas <= palavra.Length - 1 - espacos);

            if (j > 9) {
                Console.SetCursorPosition(0, 12);
                //Console.WriteLine("Erros: {0}", j);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU LOSE!");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("A palavra era: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(palavra);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ReadKey();
            } else {
                Console.SetCursorPosition(0, 12);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU WIN!");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ReadKey();
                acertos++;
            }
        }
        //vai ser carregado 1 vez para criar a área do jogo
        public static int EscritaInicio(string palavra, string tema, ref byte espacos) {
            Console.SetCursorPosition(5, 2);
            Console.Write("Tema: {0}", tema);
            Console.SetCursorPosition(0, 8);
            Console.Write("Letra: ");

            Console.SetCursorPosition(5, 5);
            for (int i = 0; i < palavra.Length; i++) { //Escrever no ecrã o nº de traços necessários
                if (palavra[i] == ' ') {
                    Console.Write("  ");
                    espacos++;
                } else {
                    Console.Write("_ ");
                }
            }
            return Console.CursorLeft;  //retornar a posicao do traço final para fazer a forca
        }
        //vai carregar todas as vezes que o utilizador interagir com o jogo
        public static void EscritaCadaInteracao(ref char[] erradas, string palavra, ref int certas, ref byte j, ref char[] existentes, int pos, int posfin) {
            //Console.WriteLine(posfin);            
            char letra = ' ';
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posfin, 2);
            Console.Write("Letras utilizadas: ");

            foreach (char element in erradas) {
                try {
                    Console.Write("{0} ", element);
                } catch { } //Exceção para a primeira ocorrencia    
            }
            var letrastr = Console.ReadKey().Key;
            if (letrastr != ConsoleKey.Escape) {
                char.TryParse(Convert.ToString(letrastr).ToLower(), out letra);
                EncontrarLetra(palavra, ref erradas, ref certas, letra, ref j, ref existentes);
                DesenharForca(j, pos);
            } else {
                j = 10;
            }
        }

        public static void EncontrarLetra(string palavra, ref char[] erradas, ref int certas, char letra, ref byte j, ref char[] existentes) {
            bool encontrada = false; //Valor booleano para saber se a letra foi encontrada ou não
            byte i = 0;
            bool nova = true;

            LimparRepetidas();
            if (letra == 0) {  //controlar as exceções
                Console.SetCursorPosition(0, 10);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Letra Inválida.");
            } else {
                foreach (char element in existentes) {
                    if (letra == element) {
                        nova = false;
                        encontrada = true;
                    }
                }
                if (nova) {
                    foreach (char letrapalavra in palavra) { //PODIA USAR AQUI ARRAY.CONTAINS
                        if (letra == letrapalavra) {
                            Console.SetCursorPosition(5 + (i * 2), 5);
                            Console.Write(letra);
                            encontrada = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(0, 10);
                            Console.Write("Letra Certa");
                            Console.ForegroundColor = ConsoleColor.Black;
                            certas++;
                            Array.Resize(ref existentes, certas + 1);
                            existentes[certas] = letra;
                        }
                        i++;
                    }
                } else {
                    Console.SetCursorPosition(0, 10);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Letra repetida!");
                }
                nova = true; //Reset da variável para fazer nova verificação
                if (!encontrada) {
                    LimparRepetidas();
                    foreach (char element in erradas) {
                        if (letra == element) {
                            nova = false;
                        }
                    }
                    if (nova) {
                        j++;
                        Array.Resize(ref erradas, j + 1);
                        erradas[j] = letra;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 10);
                        Console.Write("Letra Errada");
                    } else {
                        Console.SetCursorPosition(0, 10);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Letra repetida!");
                    }
                }
            }
        }

        public static void Leaderboard(string dirlogs) {
            int inicio = 0, fim = 0;
            int j = 0;
            Console.Clear();
            j = ContarLinhas(dirlogs);

            string[] nomes = new string[j / 2]; //o numero de linhas é sempre par
            byte[] pont = new byte[j / 2];
            //formato dos logs
            //Sessão de: tomas, jogado às: 13-01-2019
            //Nº de palavras certas: 0            
            StreamReader sr = new StreamReader(dirlogs);
            for (int i = 0; i < pont.Length - 2; i++) {
                string texto1 = sr.ReadLine();
                inicio = texto1.IndexOf(':'); //inicio e fim do nome
                fim = texto1.IndexOf(',');
                nomes[i] = texto1.Substring(inicio + 2, fim - inicio - 2); //variável com o nome do utilizador
                string texto2 = sr.ReadLine();
                pont[i] = Convert.ToByte(texto2.Substring(23));
                sr.ReadLine(); //saltar uma linha por ser em branco entre logs
            }
            Array.Sort(pont, nomes);
            Array.Reverse(pont);
            Array.Reverse(nomes);
            for (int i = 0; i < pont.Length - 2; i++) { //-2 porque o ficheiro esta preparado para receber mais valores
                Console.WriteLine("{0}º {1} - {2}", i + 1, nomes[i], pont[i]);
            }
            Console.WriteLine("Deseja guardar este Leaderboard? (S/N)");
            var res = Console.ReadKey();
            if (res.KeyChar.ToString().ToUpper() == "S") {
                GravarLeader(pont, nomes);
            } else if (res.KeyChar.ToString().ToUpper() != "N") {
                Console.WriteLine("Resposta Inválida");
            }
            //Console.Write(texto);
            //CONTINUAR A PARTIR DAQUI COMPARAR OS NOMES EXISTENTES COM ESTE E NO FIM PERGUNTAR SE QUER GRAVAR NUM FICHEIRO
            //EX LEADERBOARD 09-01-2019 12:30

            sr.Close();
        }

        public static void GravarLeader(byte[] pont, string[] nomes) {
            string dir = @"..\..\..\Ficheiros\Leaderboard - ";
            dir += DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            Console.WriteLine(dir);
            Console.ReadKey();
            var fic = File.Create(dir);
            fic.Close();

            StreamWriter sw = new StreamWriter(dir);
            for (int i = 0; i < pont.Length - 2; i++) {
                sw.WriteLine("{0}º {1} - {2}", i + 1, nomes[i], pont[i]);
            }
            sw.Close();
        }

        public static void LimparRepetidas() { //função para limpar a mensagem de letra repetida
            Console.SetCursorPosition(0, 10);
            Console.Write(new string(' ', 17));
        }

        public static void GravarLogs(string nome, int acertos, string dirlogs, string dirtemas) {
            StreamWriter sw = new StreamWriter(dirlogs, true);
            sw.WriteLine("Sessão de: {0}, jogado às: {1}", nome, DateTime.Now.ToString());
            sw.WriteLine("Nº de palavras certas: {0}\n", acertos);
            sw.Close();
            //Passar os 2 ficheiros a readonly para nao ser possivel altera los fora do programa
            File.SetAttributes(dirtemas, FileAttributes.Hidden);
            File.SetAttributes(dirtemas, FileAttributes.ReadOnly);
            File.SetAttributes(dirlogs, FileAttributes.Hidden);
            File.SetAttributes(dirlogs, FileAttributes.ReadOnly);
        }

        public static bool VerificarTemas(string dirtemas) {
            FileStream fs = new FileStream(dirtemas, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            if (sr.ReadToEnd().Length == 0) {
                sr.Close();
                return false;
            } else {
                sr.Close();
                return true;
            }
        }

        public static int ContarLinhas(string dir) {
            StreamReader sr = new StreamReader(dir);
            int i = 0;
            string linha = null;
            while ((linha = sr.ReadLine()) != null) {
                i++;
            }
            sr.Close();
            return i;
        }

        public static void Main() {
            //Criação dos ficheiros necessários
            int[] repetidos = { 0 }; //iniciar o vetor com 0 para a primeira comparação
            int acertos = 0;
            string nome = "";
            const string dir = @"..\..\..\Ficheiros", dirtemas = @"..\..\..\Ficheiros\Temas.txt", dirlogs = @"..\..\..\Ficheiros\Logs.txt";  //Uso os caminhos relativos para correr fora da pen            
            bool val = false;
            Console.SetBufferSize(120, 60);
            do {
                if (Directory.Exists(dir)) {
                    Console.WriteLine("Bem Vindo.");
                    Console.WriteLine("Jogo da Forca.");
                    Console.Write("Insira o seu nome: ");
                    nome = Console.ReadLine(); //Variável para utilizar nos logs                
                    Console.Clear();
                    val = true;
                } else {
                    Directory.CreateDirectory(dir);
                    var logs = File.Create(dirlogs);
                    logs.Close();
                    var temas = File.Create(dirtemas);
                    temas.Close();
                }
            } while (!val);

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            //MENU

            //deixar o ficheiro normal para o programa poder manipula lo
            File.SetAttributes(dirlogs, FileAttributes.Normal);
            File.SetAttributes(dirtemas, FileAttributes.Normal);
            byte op;

            do {
                Console.Clear();
                op = Nav();

                switch (op) {
                    case 0:
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine("Opção Inválida.");
                        Console.ReadKey();
                        break;
                    case 1:
                        bool verificacao = VerificarTemas(dirtemas);
                        if (verificacao) {
                            string palavra = null;
                            string tema = PickTema(ref palavra, dirtemas, ref repetidos);
                            if (tema == null) {
                                break;
                            } else {
                                Output(palavra, tema, ref acertos);
                            }
                            break;
                        } else {
                            Console.Clear();
                            Console.Write("É necessário introduzir temas primeiro!");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        Temas(dirtemas); //??Deixar alguns predefinidos??                        
                        break;
                    case 3:
                        Console.Clear();
                        Logs(dirlogs);
                        Console.ReadKey();
                        break;
                    case 4:
                        Reset(dirlogs);
                        Console.ReadKey();
                        break;
                    case 5:
                        Leaderboard(dirlogs);
                        break;
                    case 6:
                        GravarLogs(nome, acertos, dirlogs, dirtemas);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadKey();
                        break;
                }
            } while (op != 6);
        }
    }
}
/*
 *  15   ---------    
 *  16   |       |         TEMA:                           Letras erradas: a, b, c 
 *  17   |       O            
 *  18   |      /|\                                           
 *  19   |       |               _ _ _ _ _ _
 *  20 -----    /\
 * 
 *    Letra: 
 */
