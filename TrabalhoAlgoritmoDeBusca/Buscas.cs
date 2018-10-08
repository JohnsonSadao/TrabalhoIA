using System;

public class Buscas
{
    public Stopwatch sw = new Stopwatch();
    public Stack<Node> caminho = new Stack<Node>();
    public Grafo grafo = new Grafo();
    public int nosGerados;
    public int nosExpandidos;

    public List<string> BuscaProfundidadeLimitada(Vertice cidadeOrigem, Vertice cidadeDestino)
    {
        sw.Start();
        caminho.Clear();
        nosGerados = 0;
        nosExpandidos = 0;
        int limite = 1;
        while (true)
        {
            bool resultado = BPLRecursivo(CriarNo(cidadeOrigem, null), cidadeDestino, limite);
            if (resultado)
            {
                sw.Stop();
                return MontarCaminho();

            }
            limite++;
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

        foreach (Vertice vertice in grafo.PegarVizinhos(no.Vertice.Nome))
        {
            nosExpandidos += 1;
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
        nosGerados += 1;
        return new Node
        {
            Vertice = vertice,
            Pai = pai
        };
    }
}
