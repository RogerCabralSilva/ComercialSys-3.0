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
            txtPedido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtVendedor = new TextBox();
            btnAbrirPedido = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnFecharPedido = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 12);
            label1.Name = "label1";
            label1.Size = new Size(144, 50);
            label1.TabIndex = 0;
            label1.Text = "Pedido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
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
            // 
            // txtPedido
            // 
            txtPedido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPedido.ForeColor = Color.Red;
            txtPedido.Location = new Point(803, 12);
            txtPedido.Name = "txtPedido";
            txtPedido.RightToLeft = RightToLeft.Yes;
            txtPedido.Size = new Size(100, 50);
            txtPedido.TabIndex = 2;
            txtPedido.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(727, 26);
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
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Font = new Font("Segoe UI", 10F);
            btnAbrirPedido.Location = new Point(647, 223);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(106, 28);
            btnAbrirPedido.TabIndex = 5;
            btnAbrirPedido.Text = "&Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            btnAbrirPedido.Click += btnAbrirPedido_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(87, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(816, 92);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
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
            btnFecharPedido.Location = new Point(632, 486);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(106, 25);
            btnFecharPedido.TabIndex = 5;
            btnFecharPedido.Text = "&Fechar Pedido";
            btnFecharPedido.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(778, 447);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(35, 46);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(289, 23);
            textBox5.TabIndex = 3;
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
            // textBox6
            // 
            textBox6.Location = new Point(484, 46);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(122, 23);
            textBox6.TabIndex = 3;
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
            // textBox7
            // 
            textBox7.Location = new Point(628, 46);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(83, 23);
            textBox7.TabIndex = 3;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(736, 35);
            button1.Name = "button1";
            button1.Size = new Size(64, 40);
            button1.TabIndex = 5;
            button1.Text = "&Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAbrirPedido_Click;
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
            ClientSize = new Size(996, 523);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(btnFecharPedido);
            Controls.Add(btnAbrirPedido);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(txtPedido);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPedido;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirPedido;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnFecharPedido;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button button1;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}