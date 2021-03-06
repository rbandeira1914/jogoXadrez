﻿using tabuleiro;

namespace pecas
{
    class Rainha:Peca
    {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
        {


        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //NO 
            pos.definirvalores(posicao.linha - 1, posicao.coluna - 1);

            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.definirvalores(pos.linha - 1, pos.coluna - 1);
            }

            //SO
            pos.definirvalores(posicao.linha + 1, posicao.coluna + 1);

            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.definirvalores(pos.linha + 1, pos.coluna + 1);

            }

            // NE
            pos.definirvalores(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.definirvalores(pos.linha + 1, pos.coluna - 1);

            }
            //SE
            pos.definirvalores(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.definirvalores(pos.linha - 1, pos.coluna + 1);

            }

            //acima 
            pos.definirvalores(posicao.linha - 1, posicao.coluna);

            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.linha = pos.linha - 1;

            }

            //abaixo
            pos.definirvalores(posicao.linha + 1, posicao.coluna);

            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.linha = pos.linha + 1;

            }
            // a esq
            pos.definirvalores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.coluna = pos.coluna - 1;

            }
            //a dir
            pos.definirvalores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) { break; }
                pos.coluna = pos.coluna + 1;

            }



            return mat;
        }

        public bool podemover(Posicao pos)
        {
            Peca p = tab.peca(pos);

            return p == null || p.cor != cor;
        }

        public override string ToString()
        {
            return "D";
        }


    }
}
