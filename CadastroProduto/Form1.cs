using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto
{
    public partial class Form1 : Form
    {
        private List<Produto> produto = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tx_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_venda_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_porcentagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Id = tx_codigo.Text;
            p.descricao = tx_descricao.Text;
            p.preco = Convert.ToDouble(tx_preco.Text);
            p.porcentagem = Convert.ToDouble(tx_porcentagem.Text);
            p.venda = (p.preco * p.porcentagem / 100) + p.preco;

            tx_venda.Text = p.venda.ToString();

            produto.Add(p);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produto;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tx_codigo.Clear();
            tx_descricao.Clear();
            tx_preco.Clear();
            tx_porcentagem.Clear();
            tx_venda.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
