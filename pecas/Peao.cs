using tabuleiro;

namespace pecas
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {


        }

       

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca)
            {
                //acima 
                pos.definirvalores(posicao.linha - 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirvalores(posicao.linha - 2, posicao.coluna);
                if (tab.posicaoValida(pos)&& qteMovimentos==0 && livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //obliq cima esq p cprturar
                pos.definirvalores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //obli cima dir p capturar
                pos.definirvalores(posicao.linha - 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
            }
            else {
                //abaixo 
                pos.definirvalores(posicao.linha + 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirvalores(posicao.linha + 2, posicao.coluna);
                if (tab.posicaoValida(pos) && qteMovimentos == 0 && livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //obliq abaixo esq p cprturar
                pos.definirvalores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) &&  existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //obli abaixo dir p capturar
                pos.definirvalores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) &&  existeInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
            }
 
            return mat;
         
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        //public bool podemover(Posicao pos)
        //{
        //    Peca p = tab.peca(pos);

        //    return p == null || p.cor != cor;
        //}

        public override string ToString()
        {
            return "P";
        }


    }
}
