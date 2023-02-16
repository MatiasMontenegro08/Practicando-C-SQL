using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DOMINIO;
using NEGOCIO;

namespace PRESENTACION
{
	/// <summary>
	/// Description of frmPrincipal.
	/// </summary>
	public partial class frmPrincipal : Form
	{
		List<Tarea> listaTarea;
		Tarea seleccionado;
		AccesoDatos conectar = new AccesoDatos();
		NegocioTarea negocio = new NegocioTarea();
		
		public frmPrincipal()
		{
			InitializeComponent();
		}
		void FrmPrincipalLoad(object sender, EventArgs e)
		{
			cargarPlanilla();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			frmRegistro agregar = new frmRegistro();
			agregar.ShowDialog();
			cargarPlanilla();
		}
		private void cargarPlanilla()
		{
			listaTarea = negocio.Listar();
			dgvTareas.DataSource = listaTarea;
			dgvTareas.Columns["Id"].Visible = false;
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			try 
			{
				seleccionado = (Tarea)dgvTareas.CurrentRow.DataBoundItem;
				frmRegistro editar = new frmRegistro(seleccionado);
				editar.ShowDialog();
				cargarPlanilla();	
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		void BtnTerminadoClick(object sender, EventArgs e)
		{
			seleccionado = (Tarea)dgvTareas.CurrentRow.DataBoundItem;
			
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			Tarea delete;
			try 
			{
				DialogResult respuesta = MessageBox.Show("¿Desea eliminar la tarea seleccionada?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (respuesta == DialogResult.Yes) {
					delete = (Tarea)dgvTareas.CurrentRow.DataBoundItem;
					negocio.eliminar(delete.Id);
					cargarPlanilla();
				}
			} 
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}
	}
}
