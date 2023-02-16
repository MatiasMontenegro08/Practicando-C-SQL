/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 11/2/2023
 * Hora: 11:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PRESENTACION
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvTareas;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnTerminado;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.PictureBox pbImg;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.dgvTareas = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnTerminado = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.pbImg = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTareas
			// 
			this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTareas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvTareas.Location = new System.Drawing.Point(207, 13);
			this.dgvTareas.Name = "dgvTareas";
			this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTareas.Size = new System.Drawing.Size(448, 333);
			this.dgvTareas.TabIndex = 0;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAgregar.Location = new System.Drawing.Point(3, 156);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(198, 43);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditar.Location = new System.Drawing.Point(3, 205);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(198, 43);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnTerminado
			// 
			this.btnTerminado.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnTerminado.FlatAppearance.BorderSize = 0;
			this.btnTerminado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnTerminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTerminado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTerminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTerminado.Location = new System.Drawing.Point(3, 254);
			this.btnTerminado.Name = "btnTerminado";
			this.btnTerminado.Size = new System.Drawing.Size(198, 43);
			this.btnTerminado.TabIndex = 3;
			this.btnTerminado.Text = "FINALIZADA";
			this.btnTerminado.UseVisualStyleBackColor = false;
			this.btnTerminado.Click += new System.EventHandler(this.BtnTerminadoClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEliminar.Location = new System.Drawing.Point(3, 303);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(198, 43);
			this.btnEliminar.TabIndex = 4;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// pbImg
			// 
			this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
			this.pbImg.Location = new System.Drawing.Point(3, 13);
			this.pbImg.Name = "pbImg";
			this.pbImg.Size = new System.Drawing.Size(197, 134);
			this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImg.TabIndex = 5;
			this.pbImg.TabStop = false;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(667, 358);
			this.Controls.Add(this.pbImg);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnTerminado);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgvTareas);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(683, 397);
			this.MinimumSize = new System.Drawing.Size(683, 397);
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tareas Pendientes";
			this.Load += new System.EventHandler(this.FrmPrincipalLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
