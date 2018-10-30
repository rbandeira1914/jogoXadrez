using System;
using System.Globalization;
using tabuleiro;
using pecas;



namespace jogoDeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Partida partida = new Partida();

            while (!partida.terminada) {

                try
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);
                  
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Posicao Origem[linha][coluna]: ");

                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    partida.validarPosicaodeOrigem(origem);

                    bool[,] posicoespossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoespossiveis);

                    Console.WriteLine();
                    Console.Write("Posicao Destino[linha][coluna]: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaodeDestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                }
                catch (tabuleiroException e)
                {

                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

            }
            

           

           // tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(2,1));
            //tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 5));

            //Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
