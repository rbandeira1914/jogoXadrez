using tabuleiro;

namespace pecas
{
    class Cavalo : Peca
    {

        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {


        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //NO 
            pos.definirvalores(posicao.linha - 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirvalores(posicao.linha - 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //SO
            pos.definirvalores(posicao.linha + 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirvalores(posicao.linha + 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // NE
            pos.definirvalores(posicao.linha + 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirvalores(posicao.linha + 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //SE
            pos.definirvalores(posicao.linha - 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.definirvalores(posicao.linha - 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podemover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
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
            return "C";
        }
    }
}
