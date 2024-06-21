using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = Program.Usuario.Id + " - " + Program.Usuario.Nome;
        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new();
            pedido.Cliente = Cliente.ObterPorId(int.Parse(textBox1.Text));
            pedido.Usuario = Program.Usuario;
            pedido.Status = "A";
            pedido.Desconto = 0;
            pedido.inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbxProduto.Enabled = true;
            btnAbrirNovo.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (textBox1.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(textBox1.Text));
                if (cliente.Id > 0)
                {
                    textBox2.Text = cliente.Nome;
                }
            }
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoBarras.Text.Length > 4)
            {
                var produto = Produto.BuscarPorId(int.Parse(txtCodigoBarras.Text));
                if (produto.Id > 0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtValorUnit.Text = produto.ValorUnit.ToString();
                }

            }
        }

        private void InserirItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = 
                new(int.Parse(txtNumeroPedido.Text), 
                Produto.BuscarPorId(int.Parse(txtCodigoBarras.Text)), 
                double.Parse(txtValorUnit.Text), 
                double.Parse(txtQuantidade.Text),
                0
                );
            itemPedido.Inserir();
        }
    }
}
