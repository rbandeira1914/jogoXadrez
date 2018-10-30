using tabuleiro;
using System;

namespace pecas
{
    class Rei: Peca
    {
        public Rei(Tabuleiro tab, Cor cor): base(tab, cor) {

        }

        public bool podemover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0,0);

            //acima 
            pos.definirvalores(posicao.linha-1, posicao.coluna);
            if (tab.posicaoValida(pos) && podemover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo
            pos.definirvalores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esq
            pos.definirvalores(posicao.linha , posicao.coluna -1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //dir
            pos.definirvalores(posicao.linha, posicao.coluna +1 );
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //obliq cima esq
            pos.definirvalores(posicao.linha - 1, posicao.coluna -1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //obli cima dir
            pos.definirvalores(posicao.linha - 1, posicao.coluna +1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //obliq baixo esq
            pos.definirvalores(posicao.linha + 1, posicao.coluna -1 );
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // obliq baixo dir
            pos.definirvalores(posicao.linha + 1, posicao.coluna +1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }

        // Jogador

        public override string ToString()
        {
            return "R";
        }

    }
}
