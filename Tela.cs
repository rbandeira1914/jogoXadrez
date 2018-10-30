
using System;
using tabuleiro;
using pecas;
using System.Collections.Generic;
namespace jogoDeXadrez
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab) {

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                     imprimirPeca(tab.peca(i, j));
                  }
                Console.WriteLine("");
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPartida(Partida partida)
        {
            Tela.imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturas(partida);

            Console.Write("Turno: " + partida.turno);
            Console.WriteLine();

            if (!partida.terminada) {
                Console.Write("Aguardando a jogada da cor " + partida.jogadorAtual);
                if (partida.xeque) { Console.WriteLine("EM XEQUE "); }
            }
            else {
                Console.WriteLine("XEQUE MATE");
                Console.WriteLine("Jogador Vencedor: " + partida.jogadorAtual);
            }

           

        }

        public static void imprimirPecasCapturas(Partida partida) {
            Console.WriteLine("Peças Capturadas: ");
            Console.Write(" Brancas");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.Write("  Pretas");
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto ) {
            Console.Write("[");
            foreach (Peca x in conjunto) {
                Console.Write(x + " ");
            }


            Console.Write("] ");
            Console.WriteLine(" ");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i,j]) {
                        Console.BackgroundColor = fundoAlterado;
                   
                    } else {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void imprimirPeca(Peca peca) {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca + " ");
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(peca + " ");
                    Console.ForegroundColor = aux;
                }
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            int linha = int.Parse(s[0] + "");
            char coluna = s[1];

           return new PosicaoXadrez(coluna, linha);
        }




    }
}
