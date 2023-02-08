/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 4/2/2023
 * Hora: 09:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Presentacion
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblDetalle;
		private System.Windows.Forms.Label lblMonto;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.TextBox txtDetalle;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.DataGridView dgvPlanilla;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtHasta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDesde;
		private System.Windows.Forms.GroupBox groupBox3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblDetalle = new System.Windows.Forms.Label();
			this.lblMonto = new System.Windows.Forms.Label();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.txtDetalle = new System.Windows.Forms.TextBox();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.dgvPlanilla = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtHasta = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDesde = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.Location = new System.Drawing.Point(4, 14);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(100, 23);
			this.lblFecha.TabIndex = 0;
			this.lblFecha.Text = "Fecha:";
			// 
			// lblDetalle
			// 
			this.lblDetalle.Location = new System.Drawing.Point(4, 62);
			this.lblDetalle.Name = "lblDetalle";
			this.lblDetalle.Size = new System.Drawing.Size(100, 23);
			this.lblDetalle.TabIndex = 1;
			this.lblDetalle.Text = "Detalle:";
			// 
			// lblMonto
			// 
			this.lblMonto.Location = new System.Drawing.Point(4, 114);
			this.lblMonto.Name = "lblMonto";
			this.lblMonto.Size = new System.Drawing.Size(100, 23);
			this.lblMonto.TabIndex = 2;
			this.lblMonto.Text = "Monto:";
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(4, 34);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(100, 20);
			this.txtFecha.TabIndex = 3;
			// 
			// txtDetalle
			// 
			this.txtDetalle.Location = new System.Drawing.Point(4, 81);
			this.txtDetalle.Name = "txtDetalle";
			this.txtDetalle.Size = new System.Drawing.Size(171, 20);
			this.txtDetalle.TabIndex = 4;
			// 
			// txtMonto
			// 
			this.txtMonto.Location = new System.Drawing.Point(4, 131);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(118, 20);
			this.txtMonto.TabIndex = 5;
			// 
			// dgvPlanilla
			// 
			this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPlanilla.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPlanilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPlanilla.Location = new System.Drawing.Point(243, 57);
			this.dgvPlanilla.Name = "dgvPlanilla";
			this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPlanilla.Size = new System.Drawing.Size(540, 344);
			this.dgvPlanilla.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMonto);
			this.groupBox1.Controls.Add(this.txtDetalle);
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.lblMonto);
			this.groupBox1.Controls.Add(this.lblDetalle);
			this.groupBox1.Controls.Add(this.lblFecha);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(11, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(226, 172);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.Aquamarine;
			this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Location = new System.Drawing.Point(11, 227);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(226, 39);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.Aquamarine;
			this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Location = new System.Drawing.Point(11, 271);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(226, 39);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Aquamarine;
			this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(12, 359);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(226, 39);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Aquamarine;
			this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Location = new System.Drawing.Point(11, 183);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(226, 39);
			this.btnLimpiar.TabIndex = 11;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Aquamarine;
			this.btnGuardar.Enabled = false;
			this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Location = new System.Drawing.Point(11, 315);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(226, 39);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// lblFiltro
			// 
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltro.Location = new System.Drawing.Point(1, 13);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(43, 16);
			this.lblFiltro.TabIndex = 12;
			this.lblFiltro.Text = "Filtro:";
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(48, 12);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(155, 20);
			this.txtFiltro.TabIndex = 13;
			this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltroTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 17);
			this.label1.TabIndex = 14;
			this.label1.Text = "Desde:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtHasta);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtDesde);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(458, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(325, 46);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mes:";
			// 
			// txtHasta
			// 
			this.txtHasta.Location = new System.Drawing.Point(214, 13);
			this.txtHasta.Name = "txtHasta";
			this.txtHasta.Size = new System.Drawing.Size(100, 20);
			this.txtHasta.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(170, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 17);
			this.label2.TabIndex = 16;
			this.label2.Text = "Hasta:";
			// 
			// txtDesde
			// 
			this.txtDesde.Location = new System.Drawing.Point(63, 13);
			this.txtDesde.Name = "txtDesde";
			this.txtDesde.Size = new System.Drawing.Size(100, 20);
			this.txtDesde.TabIndex = 15;
			this.txtDesde.TextChanged += new System.EventHandler(this.TxtDesdeTextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblFiltro);
			this.groupBox3.Controls.Add(this.txtFiltro);
			this.groupBox3.Location = new System.Drawing.Point(243, 5);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(209, 46);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(795, 413);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvPlanilla);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Libro Ventas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
