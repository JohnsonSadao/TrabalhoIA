using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAlgoritmoDeBusca;
using TrabalhoAlgoritmoDeBusca.Features;
using TrabalhoAlgoritmoDeBusca.Infra;

namespace TelaDeBusca
{
    public partial class Form1 : Form
    {
        
        Buscas buscas = new Buscas();
        public Stack<Node> caminho;
        public Node node = new Node();
        


        public Form1()
        {
            InitializeComponent();

            caminho = new Stack<Node>();

            PopularListasOrigem();
            PopularListaDestino();

            lblNosExpandidos.Text = "";
            lblNosGerados.Text = "";
            lblPassosDados.Text = "";
            lblTempoExecucao.Text = "";
        }

        private void PopularListasOrigem()
        {
            comboBoxCidadeOrigem.DataSource = Grafo.cidadesOrigem;
        }

        private void PopularListaDestino()
        {
            comboBoxCidadeDestino.DataSource = Grafo.cidadesDestino;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = buscas.BuscaProfundidadeLimitada((Vertice)comboBoxCidadeOrigem.SelectedItem, (Vertice)comboBoxCidadeDestino.SelectedItem);

            lblNosExpandidos.Text = Convert.ToString(this.buscas.nosExpandidosPelaBusca.ToString());
            lblNosGerados.Text = this.buscas.nosGeradosPelaBusca.ToString();
            lblPassosDados.Text = this.buscas.caminho.Count().ToString();
            lblTempoExecucao.Text = this.buscas.sw.ElapsedMilliseconds.ToString();
        }

    }
}
