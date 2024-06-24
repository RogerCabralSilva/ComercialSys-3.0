namespace ComercialSys
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnAbrirNovo = new Button();
            txtNumeroPedido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtVendedor = new TextBox();
            gbxProduto = new GroupBox();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtDescricao = new TextBox();
            label9 = new Label();
            label7 = new Label();
            btnInserir = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCodigoBarras = new TextBox();
            dgvItens = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clndescricao = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            btnFecharPedido = new Button();
            txtTotal = new TextBox();
            txtOutros = new TextBox();
            txtDesconto = new TextBox();
            txtSubTotal = new TextBox();
            label8 = new Label();
            lblDesconto = new Label();
            groupBox1.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 50);
            label1.TabIndex = 0;
            label1.Text = "Pedido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnAbrirNovo);
            groupBox1.Location = new Point(87, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 88);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAbrirNovo
            // 
            btnAbrirNovo.Font = new Font("Segoe UI", 10F);
            btnAbrirNovo.Location = new Point(511, 36);
            btnAbrirNovo.Name = "btnAbrirNovo";
            btnAbrirNovo.Size = new Size(106, 28);
            btnAbrirNovo.TabIndex = 5;
            btnAbrirNovo.Text = "&Abrir Pedido";
            btnAbrirNovo.UseVisualStyleBackColor = true;
            btnAbrirNovo.Click += btnAbrirPedido_Click;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroPedido.ForeColor = Color.Red;
            txtNumeroPedido.Location = new Point(828, 9);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(100, 50);
            txtNumeroPedido.TabIndex = 2;
            txtNumeroPedido.Text = "0";
            txtNumeroPedido.TextChanged += txtNumeroPedido_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(752, 23);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 0;
            label2.Text = "Número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 81);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(114, 78);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(203, 23);
            txtVendedor.TabIndex = 4;
            txtVendedor.TextChanged += txtVendedor_TextChanged;
            // 
            // gbxProduto
            // 
            gbxProduto.Controls.Add(txtDescontoItem);
            gbxProduto.Controls.Add(txtQuantidade);
            gbxProduto.Controls.Add(txtValorUnit);
            gbxProduto.Controls.Add(txtDescricao);
            gbxProduto.Controls.Add(lblDesconto);
            gbxProduto.Controls.Add(label9);
            gbxProduto.Controls.Add(label7);
            gbxProduto.Controls.Add(btnInserir);
            gbxProduto.Controls.Add(label6);
            gbxProduto.Controls.Add(label5);
            gbxProduto.Controls.Add(label4);
            gbxProduto.Controls.Add(txtCodigoBarras);
            gbxProduto.Enabled = false;
            gbxProduto.Location = new Point(87, 257);
            gbxProduto.Name = "gbxProduto";
            gbxProduto.Size = new Size(816, 92);
            gbxProduto.TabIndex = 6;
            gbxProduto.TabStop = false;
            gbxProduto.Text = "Produto";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(644, 46);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(83, 23);
            txtDescontoItem.TabIndex = 6;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(542, 46);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(83, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(446, 46);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(78, 23);
            txtValorUnit.TabIndex = 3;
            txtValorUnit.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(160, 46);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(264, 23);
            txtDescricao.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(644, 28);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 3;
            label9.Text = "Desconto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 28);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 3;
            label7.Text = "Quantidade";
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 10F);
            btnInserir.Location = new Point(736, 35);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(64, 40);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += InserirItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(445, 28);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 3;
            label6.Text = "Valor Unitário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 28);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 28);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Códigos de barras";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(35, 46);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(100, 23);
            txtCodigoBarras.TabIndex = 3;
            txtCodigoBarras.TextChanged += txtCodigoBarras_TextChanged;
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clndescricao, clnUnidadeVenda, clnValorUnit, clnQuantidade, clnDesconto, clnValorItem });
            dgvItens.Location = new Point(87, 374);
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(675, 143);
            dgvItens.TabIndex = 7;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "Seq";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "CodBar";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clndescricao
            // 
            clndescricao.HeaderText = "Descrição";
            clndescricao.Name = "clndescricao";
            clndescricao.ReadOnly = true;
            clndescricao.Width = 200;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 60;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 80;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnValorItem
            // 
            clnValorItem.HeaderText = "Valor Item";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.Font = new Font("Segoe UI", 10F);
            btnFecharPedido.Location = new Point(632, 536);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(106, 25);
            btnFecharPedido.TabIndex = 5;
            btnFecharPedido.Text = "&Fechar Pedido";
            btnFecharPedido.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(778, 523);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 29);
            txtTotal.TabIndex = 8;
            // 
            // txtOutros
            // 
            txtOutros.Location = new Point(806, 494);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(72, 23);
            txtOutros.TabIndex = 8;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(806, 465);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(72, 23);
            txtDesconto.TabIndex = 8;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(778, 395);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 29);
            txtSubTotal.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(778, 377);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 3;
            label8.Text = "SubTotal";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(644, 13);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(44, 15);
            lblDesconto.TabIndex = 3;
            lblDesconto.Text = "R$ 0,00";
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 577);
            Controls.Add(txtSubTotal);
            Controls.Add(txtDesconto);
            Controls.Add(txtOutros);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(dgvItens);
            Controls.Add(gbxProduto);
            Controls.Add(btnFecharPedido);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(txtNumeroPedido);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxProduto.ResumeLayout(false);
            gbxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNumeroPedido;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirNovo;
        private GroupBox gbxProduto;
        private DataGridView dgvItens;
        private Button btnFecharPedido;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtDescricao;
        private Label label5;
        private TextBox txtCodigoBarras;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtQuantidade;
        private Label label7;
        private Button btnInserir;
        private TextBox txtOutros;
        private TextBox txtDesconto;
        private TextBox txtSubTotal;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clndescricao;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValorItem;
        private TextBox txtDescontoItem;
        private Label label8;
        private Label label9;
        private Label lblDesconto;
    }
}