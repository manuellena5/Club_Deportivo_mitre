namespace UI.Escritorio
{
    partial class frmActualizacionPrecios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizacionPrecios));
            this.tlpCategorias = new System.Windows.Forms.TableLayoutPanel();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAtras = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContador = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tlpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCategorias
            // 
            this.tlpCategorias.ColumnCount = 5;
            this.tlpCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57685F));
            this.tlpCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.42315F));
            this.tlpCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpCategorias.Controls.Add(this.dataListado, 0, 3);
            this.tlpCategorias.Controls.Add(this.toolStrip1, 0, 0);
            this.tlpCategorias.Controls.Add(this.label1, 0, 1);
            this.tlpCategorias.Controls.Add(this.lbContador, 0, 5);
            this.tlpCategorias.Controls.Add(this.btnEliminar, 4, 2);
            this.tlpCategorias.Controls.Add(this.btnEditar, 3, 2);
            this.tlpCategorias.Controls.Add(this.btnNuevo, 2, 2);
            this.tlpCategorias.Controls.Add(this.btnSalir, 4, 6);
            this.tlpCategorias.Controls.Add(this.btnActualizar, 3, 6);
            this.tlpCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCategorias.Location = new System.Drawing.Point(0, 0);
            this.tlpCategorias.Name = "tlpCategorias";
            this.tlpCategorias.RowCount = 6;
            this.tlpCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tlpCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tlpCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tlpCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCategorias.Size = new System.Drawing.Size(837, 477);
            this.tlpCategorias.TabIndex = 0;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_categoria,
            this.Nombre_categoria,
            this.Descripcion,
            this.Valor,
            this.fecha_condicion});
            this.tlpCategorias.SetColumnSpan(this.dataListado, 5);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 104);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tlpCategorias.SetRowSpan(this.dataListado, 3);
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(831, 319);
            this.dataListado.TabIndex = 11;
            // 
            // Id_categoria
            // 
            this.Id_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_categoria.DataPropertyName = "Id_categoria";
            this.Id_categoria.HeaderText = "Id_categoria";
            this.Id_categoria.Name = "Id_categoria";
            this.Id_categoria.ReadOnly = true;
            this.Id_categoria.Visible = false;
            // 
            // Nombre_categoria
            // 
            this.Nombre_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_categoria.DataPropertyName = "Nombre_categoria";
            this.Nombre_categoria.HeaderText = "Nombre_categoria";
            this.Nombre_categoria.Name = "Nombre_categoria";
            this.Nombre_categoria.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // fecha_condicion
            // 
            this.fecha_condicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_condicion.DataPropertyName = "Fecha_condicion";
            this.fecha_condicion.HeaderText = "fecha_condicion";
            this.fecha_condicion.Name = "fecha_condicion";
            this.fecha_condicion.ReadOnly = true;
            this.fecha_condicion.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAtras,
            this.tsbImprimir,
            this.tsbExportarExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(207, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAtras
            // 
            this.tsbAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAtras.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtras.Image")));
            this.tsbAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtras.Name = "tsbAtras";
            this.tsbAtras.Size = new System.Drawing.Size(24, 24);
            this.tsbAtras.Text = "VolverAtras";
            this.tsbAtras.Click += new System.EventHandler(this.tsbAtras_Click);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(24, 24);
            this.tsbImprimir.Text = "Imprimir";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // tsbExportarExcel
            // 
            this.tsbExportarExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportarExcel.Image")));
            this.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportarExcel.Name = "tsbExportarExcel";
            this.tsbExportarExcel.Size = new System.Drawing.Size(24, 24);
            this.tsbExportarExcel.Text = "Exportar listado a Excel";
            this.tsbExportarExcel.Click += new System.EventHandler(this.tsbExportarExcel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIAS";
            // 
            // lbContador
            // 
            this.lbContador.AutoSize = true;
            this.lbContador.Location = new System.Drawing.Point(3, 426);
            this.lbContador.Name = "lbContador";
            this.lbContador.Size = new System.Drawing.Size(50, 13);
            this.lbContador.TabIndex = 8;
            this.lbContador.Text = "Contador";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(711, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar categoria";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.Location = new System.Drawing.Point(579, 70);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 28);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar categoria";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevo.Location = new System.Drawing.Point(442, 70);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 28);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Agregar categoria";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(724, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Location = new System.Drawing.Point(588, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmActualizacionPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 477);
            this.Controls.Add(this.tlpCategorias);
            this.Name = "frmActualizacionPrecios";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmActualizacionPrecios_Load);
            this.tlpCategorias.ResumeLayout(false);
            this.tlpCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_condicion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbAtras;
        private System.Windows.Forms.Label lbContador;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripButton tsbExportarExcel;
    }
}