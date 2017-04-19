namespace UI.Escritorio
{
    partial class frmHistorialPagosXSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpHistorialxSocio = new System.Windows.Forms.TableLayoutPanel();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.NroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.cbListaBusqueda = new System.Windows.Forms.ComboBox();
            this.lbSocio = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tlpHistorialxSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHistorialxSocio
            // 
            this.tlpHistorialxSocio.ColumnCount = 4;
            this.tlpHistorialxSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.7971F));
            this.tlpHistorialxSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.2029F));
            this.tlpHistorialxSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tlpHistorialxSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tlpHistorialxSocio.Controls.Add(this.dataListado, 0, 2);
            this.tlpHistorialxSocio.Controls.Add(this.btnBuscar, 0, 1);
            this.tlpHistorialxSocio.Controls.Add(this.cbFiltro, 2, 1);
            this.tlpHistorialxSocio.Controls.Add(this.cbListaBusqueda, 3, 1);
            this.tlpHistorialxSocio.Controls.Add(this.lbSocio, 0, 3);
            this.tlpHistorialxSocio.Controls.Add(this.btnExportar, 1, 3);
            this.tlpHistorialxSocio.Controls.Add(this.btnActualizar, 2, 3);
            this.tlpHistorialxSocio.Controls.Add(this.btnSalir, 3, 3);
            this.tlpHistorialxSocio.Controls.Add(this.lbContador, 0, 4);
            this.tlpHistorialxSocio.Controls.Add(this.label1, 1, 1);
            this.tlpHistorialxSocio.Controls.Add(this.toolStrip1, 0, 0);
            this.tlpHistorialxSocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHistorialxSocio.Location = new System.Drawing.Point(0, 0);
            this.tlpHistorialxSocio.Name = "tlpHistorialxSocio";
            this.tlpHistorialxSocio.RowCount = 5;
            this.tlpHistorialxSocio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.66667F));
            this.tlpHistorialxSocio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.33333F));
            this.tlpHistorialxSocio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tlpHistorialxSocio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpHistorialxSocio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHistorialxSocio.Size = new System.Drawing.Size(568, 450);
            this.tlpHistorialxSocio.TabIndex = 0;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroSocio,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.Categoria,
            this.MesCuota,
            this.AnioCuota,
            this.Importe});
            this.tlpHistorialxSocio.SetColumnSpan(this.dataListado, 4);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 67);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(562, 323);
            this.dataListado.TabIndex = 19;
            // 
            // NroSocio
            // 
            this.NroSocio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NroSocio.DataPropertyName = "NroSocio";
            this.NroSocio.HeaderText = "Nro Socio";
            this.NroSocio.Name = "NroSocio";
            this.NroSocio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // MesCuota
            // 
            this.MesCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MesCuota.DataPropertyName = "Mes";
            this.MesCuota.HeaderText = "Mes pago";
            this.MesCuota.Name = "MesCuota";
            this.MesCuota.ReadOnly = true;
            // 
            // AnioCuota
            // 
            this.AnioCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnioCuota.DataPropertyName = "AnioCuota";
            this.AnioCuota.HeaderText = "Año pago";
            this.AnioCuota.Name = "AnioCuota";
            this.AnioCuota.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(3, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar socio";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // cbFiltro
            // 
            this.cbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Mes",
            "Año"});
            this.cbFiltro.Location = new System.Drawing.Point(254, 35);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(131, 21);
            this.cbFiltro.TabIndex = 4;
            this.cbFiltro.SelectedValueChanged += new System.EventHandler(this.cbFiltro_SelectedValueChanged);
            // 
            // cbListaBusqueda
            // 
            this.cbListaBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbListaBusqueda.FormattingEnabled = true;
            this.cbListaBusqueda.Location = new System.Drawing.Point(400, 35);
            this.cbListaBusqueda.Name = "cbListaBusqueda";
            this.cbListaBusqueda.Size = new System.Drawing.Size(156, 21);
            this.cbListaBusqueda.TabIndex = 7;
            this.cbListaBusqueda.SelectedValueChanged += new System.EventHandler(this.cbListaBusqueda_SelectedValueChanged);
            // 
            // lbSocio
            // 
            this.lbSocio.AutoSize = true;
            this.lbSocio.Location = new System.Drawing.Point(3, 393);
            this.lbSocio.Name = "lbSocio";
            this.lbSocio.Size = new System.Drawing.Size(40, 13);
            this.lbSocio.TabIndex = 12;
            this.lbSocio.Text = "Socio: ";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.Location = new System.Drawing.Point(143, 399);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(105, 23);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar listado";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Location = new System.Drawing.Point(282, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(440, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lbContador
            // 
            this.lbContador.AutoSize = true;
            this.lbContador.Location = new System.Drawing.Point(3, 429);
            this.lbContador.Name = "lbContador";
            this.lbContador.Size = new System.Drawing.Size(56, 13);
            this.lbContador.TabIndex = 20;
            this.lbContador.Text = "Contador: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar por:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(140, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Escritorio.Properties.Resources.boton_editar_perfil_de_usuario_318_32453;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton1";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Escritorio.Properties.Resources.icono_Eliminar;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton2";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // frmHistorialPagosXSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.tlpHistorialxSocio);
            this.Name = "frmHistorialPagosXSocio";
            this.Text = "Historial de pagos";
            this.Load += new System.EventHandler(this.frmHistorialPagosXSocio_Load);
            this.tlpHistorialxSocio.ResumeLayout(false);
            this.tlpHistorialxSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHistorialxSocio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbListaBusqueda;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lbSocio;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label lbContador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}