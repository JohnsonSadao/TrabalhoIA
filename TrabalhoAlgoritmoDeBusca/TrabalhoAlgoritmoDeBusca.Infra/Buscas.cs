using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlgoritmoDeBusca.Infra
{
    public class Buscas
    {
        public Stack<string> caminho;

        public Stack<string> BuscaProfundidadeLimitada(Vertice cidadeOrigem, Vertice cidadeDestino, int limite)
        {
            caminho.Clear();
            caminho.Push(cidadeOrigem.Nome);
            return;
        }

        public Stack<string> BPLRecursivo(Vertice atual, Vertice cidadeDestino, int limite)
        {
            if (ChecarObjetivo(atual, cidadeDestino))
            {
                caminho.Push(atual.Nome);
                return caminho;
            }
            if (limite == 0)
            {

            }


        }

        public bool ChecarObjetivo(Vertice cidadeDestino, Vertice CidadeAtual)
        {
            if (cidadeDestino.Nome == CidadeAtual.Nome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void BuscaProfundidade(Vertice cidade, Vertice cidadeDestino)
        {
            caminho.Push(cidade.Nome);
            if (cidadeDestino.Nome != cidade.Nome)
            {
                BuscaProfundidade.(cidade.Neighbors.First, cidadeDestino);
            }
        }

    }
}
