using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlgoritmoDeBusca
{
    public class Vertice
    {
        public string Nome { get; set; }
        public string Capital { get; set; } 
        public LinkedList<Vertice> Neighbors { get; set; }
    }
}
