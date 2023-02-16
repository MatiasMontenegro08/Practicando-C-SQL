/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 11/2/2023
 * Hora: 11:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PRESENTACION
{
	partial class frmRegistro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTarea;
		private System.Windows.Forms.TextBox txtTarea;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		
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
			this.lblTarea = new System.Windows.Forms.Label();
			this.txtTarea = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTarea
			// 
			this.lblTarea.Location = new System.Drawing.Point(12, 18);
			this.lblTarea.Name = "lblTarea";
			this.lblTarea.Size = new System.Drawing.Size(48, 16);
			this.lblTarea.TabIndex = 0;
			this.lblTarea.Text = "TAREA:";
			// 
			// txtTarea
			// 
			this.txtTarea.Location = new System.Drawing.Point(66, 14);
			this.txtTarea.Multiline = true;
			this.txtTarea.Name = "txtTarea";
			this.txtTarea.Size = new System.Drawing.Size(292, 20);
			this.txtTarea.TabIndex = 1;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAceptar.Location = new System.Drawing.Point(66, 42);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(143, 37);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "ACEPTAR";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancelar.Location = new System.Drawing.Point(215, 42);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(143, 37);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// frmRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(371, 89);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtTarea);
			this.Controls.Add(this.lblTarea);
			this.Name = "frmRegistro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AGREGAR TAREA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
