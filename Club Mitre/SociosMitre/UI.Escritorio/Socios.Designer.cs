﻿namespace UI.Escritorio
{
    partial class Socios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Socios));
            this.tscSocios = new System.Windows.Forms.ToolStripContainer();
            this.tlpSocios = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsSocios = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.NroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscSocios.ContentPanel.SuspendLayout();
            this.tscSocios.TopToolStripPanel.SuspendLayout();
            this.tscSocios.SuspendLayout();
            this.tlpSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.tsSocios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscSocios
            // 
            // 
            // tscSocios.ContentPanel
            // 
            this.tscSocios.ContentPanel.Controls.Add(this.tlpSocios);
            this.tscSocios.ContentPanel.Size = new System.Drawing.Size(818, 420);
            this.tscSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscSocios.Location = new System.Drawing.Point(0, 0);
            this.tscSocios.Name = "tscSocios";
            this.tscSocios.Size = new System.Drawing.Size(818, 445);
            this.tscSocios.TabIndex = 0;
            this.tscSocios.Text = "toolStripContainer1";
            // 
            // tscSocios.TopToolStripPanel
            // 
            this.tscSocios.TopToolStripPanel.Controls.Add(this.tsSocios);
            this.tscSocios.TopToolStripPanel.Click += new System.EventHandler(this.tscSocios_TopToolStripPanel_Click);
            // 
            // tlpSocios
            // 
            this.tlpSocios.ColumnCount = 2;
            this.tlpSocios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSocios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSocios.Controls.Add(this.dgvSocios, 0, 0);
            this.tlpSocios.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpSocios.Controls.Add(this.btnSalir, 1, 1);
            this.tlpSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSocios.Location = new System.Drawing.Point(0, 0);
            this.tlpSocios.Name = "tlpSocios";
            this.tlpSocios.RowCount = 2;
            this.tlpSocios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSocios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSocios.Size = new System.Drawing.Size(818, 420);
            this.tlpSocios.TabIndex = 0;
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroSocio,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.Categoria,
            this.Dni,
            this.FechaNac,
            this.Mes_cuota,
            this.Anio_cuota});
            this.tlpSocios.SetColumnSpan(this.dgvSocios, 2);
            this.dgvSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSocios.Location = new System.Drawing.Point(3, 3);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocios.Size = new System.Drawing.Size(812, 385);
            this.dgvSocios.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(659, 394);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(740, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsSocios
            // 
            this.tsSocios.Dock = System.Windows.Forms.DockStyle.None;
            this.tsSocios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsSocios.Location = new System.Drawing.Point(3, 0);
            this.tsSocios.Name = "tsSocios";
            this.tsSocios.Size = new System.Drawing.Size(81, 25);
            this.tsSocios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton2";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // NroSocio
            // 
            this.NroSocio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NroSocio.DataPropertyName = "NroSocio";
            this.NroSocio.HeaderText = "NroSocio";
            this.NroSocio.Name = "NroSocio";
            this.NroSocio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.DataPropertyName = "categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dni.DataPropertyName = "dni";
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Visible = false;
            // 
            // FechaNac
            // 
            this.FechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaNac.DataPropertyName = "FechaNac";
            this.FechaNac.HeaderText = "FechaNac";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            this.FechaNac.Visible = false;
            // 
            // Mes_cuota
            // 
            this.Mes_cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mes_cuota.DataPropertyName = "Mes_cuota";
            this.Mes_cuota.HeaderText = "Ult_Mes_Pago";
            this.Mes_cuota.Name = "Mes_cuota";
            this.Mes_cuota.ReadOnly = true;
            // 
            // Anio_cuota
            // 
            this.Anio_cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Anio_cuota.DataPropertyName = "Anio_cuota";
            this.Anio_cuota.HeaderText = "Año de cuota";
            this.Anio_cuota.Name = "Anio_cuota";
            this.Anio_cuota.ReadOnly = true;
            // 
            // Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 445);
            this.Controls.Add(this.tscSocios);
            this.Name = "Socios";
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.Socios_Load);
            this.tscSocios.ContentPanel.ResumeLayout(false);
            this.tscSocios.TopToolStripPanel.ResumeLayout(false);
            this.tscSocios.TopToolStripPanel.PerformLayout();
            this.tscSocios.ResumeLayout(false);
            this.tscSocios.PerformLayout();
            this.tlpSocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.tsSocios.ResumeLayout(false);
            this.tsSocios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscSocios;
        private System.Windows.Forms.TableLayoutPanel tlpSocios;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsSocios;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio_cuota;
    }
}
