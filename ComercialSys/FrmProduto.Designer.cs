﻿namespace ComercialSys
{
    partial class FrmProduto
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
            dgtProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnCodigoBarras = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            gpProdutos = new GroupBox();
            dtpDataCad = new DateTimePicker();
            npEstoqueMinimo = new NumericUpDown();
            btnCosultar = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtCodigosBarras = new TextBox();
            txtDescricao = new TextBox();
            txtDesconto = new TextBox();
            txtValorUnit = new TextBox();
            txtUnidadeVenda = new TextBox();
            label1 = new Label();
            txtCategoriaId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgtProdutos).BeginInit();
            gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            SuspendLayout();
            // 
            // dgtProdutos
            // 
            dgtProdutos.AllowUserToAddRows = false;
            dgtProdutos.AllowUserToDeleteRows = false;
            dgtProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnDescricao, clnCodigoBarras, clnValorUnit, clnUnidadeVenda, clnEstoqueMinimo, clnCategoria, clnDesconto });
            dgtProdutos.Location = new Point(50, 394);
            dgtProdutos.Name = "dgtProdutos";
            dgtProdutos.ReadOnly = true;
            dgtProdutos.RowHeadersVisible = false;
            dgtProdutos.Size = new Size(748, 150);
            dgtProdutos.TabIndex = 6;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnCodigoBarras
            // 
            clnCodigoBarras.HeaderText = "Código de Barras";
            clnCodigoBarras.Name = "clnCodigoBarras";
            clnCodigoBarras.ReadOnly = true;
            clnCodigoBarras.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 120;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 130;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.HeaderText = "Estoque Minimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            clnEstoqueMinimo.Width = 130;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // gpProdutos
            // 
            gpProdutos.Controls.Add(dtpDataCad);
            gpProdutos.Controls.Add(npEstoqueMinimo);
            gpProdutos.Controls.Add(btnCosultar);
            gpProdutos.Controls.Add(btnAdicionar);
            gpProdutos.Controls.Add(btnEditar);
            gpProdutos.Controls.Add(label7);
            gpProdutos.Controls.Add(label6);
            gpProdutos.Controls.Add(label8);
            gpProdutos.Controls.Add(label3);
            gpProdutos.Controls.Add(label5);
            gpProdutos.Controls.Add(label4);
            gpProdutos.Controls.Add(label2);
            gpProdutos.Controls.Add(txtCodigosBarras);
            gpProdutos.Controls.Add(txtDescricao);
            gpProdutos.Controls.Add(txtDesconto);
            gpProdutos.Controls.Add(txtCategoriaId);
            gpProdutos.Controls.Add(txtValorUnit);
            gpProdutos.Controls.Add(txtUnidadeVenda);
            gpProdutos.Location = new Point(50, 59);
            gpProdutos.Name = "gpProdutos";
            gpProdutos.Size = new Size(748, 306);
            gpProdutos.TabIndex = 5;
            gpProdutos.TabStop = false;
            gpProdutos.Text = "Produtos";
            // 
            // dtpDataCad
            // 
            dtpDataCad.Format = DateTimePickerFormat.Custom;
            dtpDataCad.Location = new Point(552, 155);
            dtpDataCad.Name = "dtpDataCad";
            dtpDataCad.Size = new Size(102, 23);
            dtpDataCad.TabIndex = 4;
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(440, 155);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(39, 23);
            npEstoqueMinimo.TabIndex = 7;
            // 
            // btnCosultar
            // 
            btnCosultar.Location = new Point(459, 206);
            btnCosultar.Name = "btnCosultar";
            btnCosultar.Size = new Size(75, 23);
            btnCosultar.TabIndex = 5;
            btnCosultar.Text = "&Consultar";
            btnCosultar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(263, 206);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(364, 206);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 137);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 2;
            label7.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 136);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 2;
            label6.Text = "Categoria id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 188);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 2;
            label8.Text = "Desconto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 81);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 2;
            label5.Text = "Unidade de Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 81);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 2;
            label4.Text = "Valor Unitário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 82);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "Código de barras";
            // 
            // txtCodigosBarras
            // 
            txtCodigosBarras.Location = new Point(132, 99);
            txtCodigosBarras.Name = "txtCodigosBarras";
            txtCodigosBarras.Size = new Size(140, 23);
            txtCodigosBarras.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(132, 154);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(188, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(132, 207);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(117, 23);
            txtDesconto.TabIndex = 1;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(296, 99);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(117, 23);
            txtValorUnit.TabIndex = 1;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(440, 99);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "EX: Caixa";
            txtUnidadeVenda.Size = new Size(117, 23);
            txtUnidadeVenda.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 18);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 4;
            label1.Text = "Produtos";
            // 
            // txtCategoriaId
            // 
            txtCategoriaId.Location = new Point(356, 158);
            txtCategoriaId.Name = "txtCategoriaId";
            txtCategoriaId.Size = new Size(44, 23);
            txtCategoriaId.TabIndex = 1;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 581);
            Controls.Add(dgtProdutos);
            Controls.Add(gpProdutos);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgtProdutos).EndInit();
            gpProdutos.ResumeLayout(false);
            gpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgtProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnCodigoBarras;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnDesconto;
        private GroupBox gpProdutos;
        private DateTimePicker dtpDataCad;
        private MaskedTextBox mtbDesconto;
        private MaskedTextBox mtbValorUnit;
        private NumericUpDown npEstoqueMinimo;
        private Button btnCosultar;
        private Button btnAdicionar;
        private Button btnEditar;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtCodigosBarras;
        private TextBox txtDescricao;
        private TextBox txtUnidadeVenda;
        private Label label1;
        private TextBox txtValorUnit;
        private TextBox txtDesconto;
        private TextBox txtCategoriaId;
    }
}