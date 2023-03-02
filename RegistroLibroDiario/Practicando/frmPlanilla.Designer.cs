namespace Practicando
{
    partial class frmPlanilla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbIngEgr = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.rbEgreso = new System.Windows.Forms.RadioButton();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblErrorDetalle = new System.Windows.Forms.Label();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            this.gbIngEgr.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlanilla.Location = new System.Drawing.Point(352, 12);
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanilla.Size = new System.Drawing.Size(436, 426);
            this.dgvPlanilla.TabIndex = 0;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(12, 27);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(58, 13);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "DETALLE:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "FECHA:";
            // 
            // gbIngEgr
            // 
            this.gbIngEgr.Controls.Add(this.lblErrorMonto);
            this.gbIngEgr.Controls.Add(this.txtMonto);
            this.gbIngEgr.Controls.Add(this.rbEgreso);
            this.gbIngEgr.Controls.Add(this.rbIngreso);
            this.gbIngEgr.Location = new System.Drawing.Point(15, 144);
            this.gbIngEgr.Name = "gbIngEgr";
            this.gbIngEgr.Size = new System.Drawing.Size(231, 106);
            this.gbIngEgr.TabIndex = 4;
            this.gbIngEgr.TabStop = false;
            this.gbIngEgr.Text = "INGRESO Y EGRESO";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(10, 54);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(203, 20);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // rbEgreso
            // 
            this.rbEgreso.AutoSize = true;
            this.rbEgreso.Location = new System.Drawing.Point(128, 31);
            this.rbEgreso.Name = "rbEgreso";
            this.rbEgreso.Size = new System.Drawing.Size(70, 17);
            this.rbEgreso.TabIndex = 1;
            this.rbEgreso.TabStop = true;
            this.rbEgreso.Text = "EGRESO";
            this.rbEgreso.UseVisualStyleBackColor = true;
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Location = new System.Drawing.Point(10, 31);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(74, 17);
            this.rbIngreso.TabIndex = 0;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "INGRESO";
            this.rbIngreso.UseVisualStyleBackColor = true;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(15, 47);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(221, 20);
            this.txtDetalle.TabIndex = 0;
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(15, 105);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(95, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(12, 256);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(113, 256);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 34);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(113, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.btnBuscar);
            this.gbFiltro.Controls.Add(this.txtHasta);
            this.gbFiltro.Controls.Add(this.txtDesde);
            this.gbFiltro.Controls.Add(this.lblHasta);
            this.gbFiltro.Controls.Add(this.lblDesde);
            this.gbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFiltro.Location = new System.Drawing.Point(12, 364);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(256, 102);
            this.gbFiltro.TabIndex = 10;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "FILTRO RÁPIDO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(13, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(231, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(149, 40);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(95, 20);
            this.txtHasta.TabIndex = 1;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(13, 40);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(95, 20);
            this.txtDesde.TabIndex = 0;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(175, 20);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "HASTA:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(37, 20);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(47, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "DESDE:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(12, 296);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 34);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblErrorDetalle
            // 
            this.lblErrorDetalle.AutoSize = true;
            this.lblErrorDetalle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDetalle.Location = new System.Drawing.Point(12, 70);
            this.lblErrorDetalle.Name = "lblErrorDetalle";
            this.lblErrorDetalle.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDetalle.TabIndex = 11;
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.AutoSize = true;
            this.lblErrorFecha.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFecha.Location = new System.Drawing.Point(12, 128);
            this.lblErrorFecha.Name = "lblErrorFecha";
            this.lblErrorFecha.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFecha.TabIndex = 12;
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMonto.Location = new System.Drawing.Point(12, 81);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMonto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(634, 446);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(154, 26);
            this.txtTotal.TabIndex = 14;
            // 
            // frmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorFecha);
            this.Controls.Add(this.lblErrorDetalle);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.gbIngEgr);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.dgvPlanilla);
            this.Name = "frmPlanilla";
            this.Text = "LIBRO DIARIO";
            this.Load += new System.EventHandler(this.frmPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.gbIngEgr.ResumeLayout(false);
            this.gbIngEgr.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbIngEgr;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.RadioButton rbEgreso;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblErrorDetalle;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.Label lblErrorMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

