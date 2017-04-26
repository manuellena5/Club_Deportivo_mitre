namespace UI.Escritorio
{
    partial class frmBalance
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteMutual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnTraerBalance = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbAnio = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.80663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.19337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAnio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataListado, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbTipo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCategoria, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbInfo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnTraerBalance, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExportar, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbAnio, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbTipo, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbCategoria, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.30435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.69565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver balance por: ";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(305, 481);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(108, 481);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cbAnio
            // 
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Location = new System.Drawing.Point(108, 22);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(121, 21);
            this.cbAnio.TabIndex = 1;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.ImporteClub,
            this.ImporteMutual,
            this.TotalSuma});
            this.tableLayoutPanel1.SetColumnSpan(this.dataListado, 3);
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 107);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(567, 308);
            this.dataListado.TabIndex = 9;
            // 
            // Mes
            // 
            this.Mes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mes.DataPropertyName = "Mes";
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            // 
            // ImporteClub
            // 
            this.ImporteClub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImporteClub.DataPropertyName = "ImporteClub";
            this.ImporteClub.HeaderText = "Club";
            this.ImporteClub.Name = "ImporteClub";
            this.ImporteClub.ReadOnly = true;
            // 
            // ImporteMutual
            // 
            this.ImporteMutual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImporteMutual.DataPropertyName = "ImporteMutual";
            this.ImporteMutual.HeaderText = "Mutual";
            this.ImporteMutual.Name = "ImporteMutual";
            this.ImporteMutual.ReadOnly = true;
            // 
            // TotalSuma
            // 
            this.TotalSuma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSuma.DataPropertyName = "TotalSuma";
            this.TotalSuma.HeaderText = "Total";
            this.TotalSuma.Name = "TotalSuma";
            this.TotalSuma.ReadOnly = true;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Club",
            "Mutual"});
            this.cbTipo.Location = new System.Drawing.Point(108, 49);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 2;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(108, 76);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Por año: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Por tipo: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Por categoria: ";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(3, 418);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(67, 13);
            this.lbInfo.TabIndex = 14;
            this.lbInfo.Text = "Balance por:";
            // 
            // btnTraerBalance
            // 
            this.btnTraerBalance.Location = new System.Drawing.Point(305, 76);
            this.btnTraerBalance.Name = "btnTraerBalance";
            this.btnTraerBalance.Size = new System.Drawing.Size(75, 25);
            this.btnTraerBalance.TabIndex = 15;
            this.btnTraerBalance.Text = "Ver balance";
            this.btnTraerBalance.UseVisualStyleBackColor = true;
            this.btnTraerBalance.Click += new System.EventHandler(this.btnTraerBalance_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(305, 49);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 21);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(3, 437);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(35, 13);
            this.lbAnio.TabIndex = 17;
            this.lbAnio.Text = "label5";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(3, 457);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(35, 13);
            this.lbTipo.TabIndex = 18;
            this.lbTipo.Text = "label6";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(3, 478);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(35, 13);
            this.lbCategoria.TabIndex = 19;
            this.lbCategoria.Text = "label7";
            // 
            // frmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmBalance";
            this.Text = "frmBalance";
            this.Load += new System.EventHandler(this.frmBalance_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteMutual;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSuma;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnTraerBalance;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbCategoria;
    }
}