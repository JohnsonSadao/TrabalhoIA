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
        //public List<Vertice> Neighbors { get; set; }

        public Vertice()
        {
            Neighbors = new List<Vertice>();
        }

        public override string ToString()
        {
            return Nome + " - " + Capital;
        }
    }
}
