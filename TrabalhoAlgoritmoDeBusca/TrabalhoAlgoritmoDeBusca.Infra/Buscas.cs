using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAlgoritmoDeBusca.Features;

namespace TrabalhoAlgoritmoDeBusca.Infra
{
    public class Buscas
    {
        public Stack<Node> caminho;

        public List<string> BuscaProfundidadeLimitada(Vertice cidadeOrigem , Vertice cidadeDestino, int limite)
        {
            caminho.Clear();
            bool resultado = BPLRecursivo(CriarNo(cidadeOrigem, null), cidadeDestino, limite);
            if (resultado)
            {
                return MontarCaminho();
            }
            else
            {
                return new List<string> { "Não foi possivel achar um caminho "};
            }

        }

        public bool BPLRecursivo(Node no, Vertice cidadeDestino, int limite)
        {
            caminho.Push(no);
            if (ChecarObjetivo(no.Vertice, cidadeDestino))
            {                
                return true;
            }
            if (limite == 0)
            {
                caminho.Pop();
                return false;
            }
            foreach(Vertice vertice in no.Vertice.Neighbors)
            {
                Node filho = CriarNo(vertice, no);
                bool resultado = BPLRecursivo(filho, cidadeDestino, limite - 1);
                if(resultado == true)
                {
                    return true;
                }
            }
            caminho.Pop();
            return false;
                        
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

        public List<string> MontarCaminho()
        {
            List<string> caminhoCerto = new List<string>();

            Node nodo = caminho.Pop();
            caminhoCerto.Add(nodo.Vertice.ToString());

            Node pai = nodo.Pai;

            while(pai != null){

                caminhoCerto.Add(pai.Vertice.ToString());

                pai = pai.Pai;
            }

            return caminhoCerto;

        }
        

        //public void BuscaProfundidade(Vertice cidade, Vertice cidadeDestino)
        //{
        //    caminho.Push(cidade.Nome);
        //    if (cidadeDestino.Nome != cidade.Nome)
        //    {
        //        BuscaProfundidade(cidade.Neighbors.First, cidadeDestino);
        //    }
        //}

        public Node CriarNo(Vertice vertice, Node pai)
        {
            return new Node { Vertice = vertice,
                                Pai = pai};
        }
    }
}


