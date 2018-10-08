using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAlgoritmoDeBusca.Features;

namespace TrabalhoAlgoritmoDeBusca.Infra
{
   public class Buscas
    {
        public Stopwatch sw = new Stopwatch();
        public Stack<Node> caminho = new Stack<Node>();
        public Grafo grafo = new Grafo();
        public Node node = new Node();
        public int nosExpandidosPelaBusca;
        public int nosGeradosPelaBusca;

        public  List<string> BuscaProfundidadeLimitada(Vertice cidadeOrigem, Vertice cidadeDestino)
        {
            sw.Start();
            caminho.Clear();
            nosGeradosPelaBusca = 0;
            nosExpandidosPelaBusca = 0;
            int limite = 1;
            while (true)
            {
                nosExpandidosPelaBusca = 0;
                nosGeradosPelaBusca = 0;
                bool resultado = BPLRecursivo(CriarNo(cidadeOrigem, null), cidadeDestino, limite);
                if (resultado)
                {
                    sw.Stop();
                    return MontarCaminho();

                }
                limite++;
            }
        }

        public  bool BPLRecursivo(Node no, Vertice cidadeDestino, int limite)
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
            //nosExpandidosPelaBusca = 0;
            //nosGeradosPelaBusca = 0;
            foreach (Vertice vertice in grafo.PegarVizinhos(no.Vertice.Nome))
            {
             
              nosExpandidosPelaBusca  += 1;
                Node filho = CriarNo(vertice, no);
                bool resultado = BPLRecursivo(filho, cidadeDestino, limite - 1);
                if (resultado == true)
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

            while (pai != null)
            {

                caminhoCerto.Add(pai.Vertice.ToString());

                pai = pai.Pai;
            }

            return caminhoCerto;

        }
       
        public Node CriarNo(Vertice vertice, Node pai)
        {
            
            nosGeradosPelaBusca += 1;
            return new Node
            {
                Vertice = vertice,
                Pai = pai
            };
        }
        
        
    }

   

}
