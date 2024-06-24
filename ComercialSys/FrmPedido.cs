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

        Produto produto = new();

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoBarras.Text.Length > 4)
            {
                var produto = Produto.BuscarPorId(int.Parse(txtCodigoBarras.Text));
                if (produto.Id > 0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtValorUnit.Text = produto.ValorUnit.ToString();
                    lblDesconto.Text = $"R$ {produto.ClasseDesconto * produto.ValorUnit}";
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
                double.Parse(txtDesconto.Text)
                );
            itemPedido.Inserir();

            // Limpar o DataGrid
            dgvItens.Rows.Clear();
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtNumeroPedido.Text));
            int count = 0;
            double subTotal = 0;

            foreach (var item in itens)
            {
                dgvItens.Rows.Add();
                dgvItens.Rows[count].Cells[0].Value = $"#{count + 1}";
                dgvItens.Rows[count].Cells[1].Value = item.Produto.CodBarras;
                dgvItens.Rows[count].Cells[2].Value = item.Produto.UnidadeVenda;
                dgvItens.Rows[count].Cells[3].Value = item.Produto.ValorUnit;
                dgvItens.Rows[count].Cells[4].Value = item.Quantidade;
                dgvItens.Rows[count].Cells[5].Value = item.Produto.CodBarras;
                dgvItens.Rows[count].Cells[6].Value = item.Desconto;
                dgvItens.Rows[count].Cells[7].Value = item.ValorUnit * item.Quantidade - item.Desconto;

                subTotal += item.ValorUnit * item.Quantidade - item.Desconto;

                count++;
            }

            txtSubTotal.Text = subTotal.ToString();

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Length > 0)
            {
                lblDesconto.Text = $"R$ {produto.ClasseDesconto * produto.ValorUnit * decimal.Parse(txtQuantidade.Text)}";
            }
        }
    }
}
