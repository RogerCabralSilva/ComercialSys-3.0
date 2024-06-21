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
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtDescricao = new TextBox();
            label7 = new Label();
            btnInserir = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCodigoBarras = new TextBox();
            dataGridView1 = new DataGridView();
            btnFecharPedido = new Button();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            groupBox1.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            gbxProduto.Controls.Add(txtQuantidade);
            gbxProduto.Controls.Add(txtValorUnit);
            gbxProduto.Controls.Add(txtDescricao);
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
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(628, 46);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(83, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(484, 46);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(122, 23);
            txtValorUnit.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(176, 46);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(289, 23);
            txtDescricao.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(628, 28);
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
            label6.Location = new Point(484, 28);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 3;
            label6.Text = "Valor Unitário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 28);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 96);
            dataGridView1.TabIndex = 7;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.Font = new Font("Segoe UI", 10F);
            btnFecharPedido.Location = new Point(632, 494);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(106, 25);
            btnFecharPedido.TabIndex = 5;
            btnFecharPedido.Text = "&Fechar Pedido";
            btnFecharPedido.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(778, 441);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(778, 408);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(778, 379);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 8;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 553);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnFecharPedido;
        private TextBox textBox3;
        private Label label4;
        private TextBox txtDescricao;
        private Label label5;
        private TextBox txtCodigoBarras;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtQuantidade;
        private Label label7;
        private Button btnInserir;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}