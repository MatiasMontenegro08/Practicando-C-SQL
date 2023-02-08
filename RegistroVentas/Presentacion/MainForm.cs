/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 4/2/2023
 * Hora: 09:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dominio;
using Negocio;
namespace Presentacion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<Archivo> listaArchivo;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			cargarPlanilla();
		}
		private void cargarPlanilla()
		{
			NegocioArchivo lista = new NegocioArchivo();
			listaArchivo = lista.Listar();
			dgvPlanilla.DataSource = listaArchivo;
			dgvPlanilla.Columns["Id"].Visible = false;
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			limpiarTxtbox();
		}
		private void limpiarTxtbox()
		{
			txtFecha.Text = "";
			txtDetalle.Text = "";
			txtMonto.Text = "";
			txtFecha.Focus();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			agregarRegistro();
			cargarPlanilla();
		}
		private void agregarRegistro()
		{
			NegocioArchivo dato = new NegocioArchivo();
			Archivo registro = new Archivo();
			try 
			{
				registro.Fecha = txtFecha.Text;
				registro.Detalle = txtDetalle.Text;
				registro.Monto = Convert.ToDecimal(txtMonto.Text);
				dato.Agregar(registro);
				MessageBox.Show("Registro agregado!");
				limpiarTxtbox();
			} 
			catch (Exception ex) 
			{	
				throw ex;
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			NegocioArchivo negocio = new NegocioArchivo();
			Archivo seleccionado;
			try {
				DialogResult respuesta = MessageBox.Show("Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (respuesta == DialogResult.Yes) 
				{
					seleccionado = (Archivo)dgvPlanilla.CurrentRow.DataBoundItem;
					negocio.EliminarRegistro(seleccionado);
					cargarPlanilla();
				}
			} 
			catch (Exception ex)
			{
				throw ex;
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			NegocioArchivo negocio = new NegocioArchivo();
			Archivo seleccionado;
			try 
			{
				seleccionado = (Archivo)dgvPlanilla.CurrentRow.DataBoundItem;
				cargarTextbox(seleccionado);
			} 
			catch (Exception ex)
			{
				throw ex;
			}
		}
		private void cargarTextbox(Archivo seleccionado)
		{
			txtFecha.Text = seleccionado.Fecha;
			txtDetalle.Text = seleccionado.Detalle;
			txtMonto.Text = seleccionado.Monto.ToString();
			btnGuardar.Enabled = true;
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			NegocioArchivo negocio = new NegocioArchivo();
			Archivo seleccionado = (Archivo)dgvPlanilla.CurrentRow.DataBoundItem;
			if (txtFecha.Text != "" && txtDetalle.Text != "" && txtMonto.Text != "") 
			{
				seleccionado.Fecha = txtFecha.Text;
				seleccionado.Detalle = txtDetalle.Text;
				seleccionado.Monto = Convert.ToDecimal(txtMonto.Text);
				negocio.Editar(seleccionado);
			}
			btnGuardar.Enabled = false;
			limpiarTxtbox();
			cargarPlanilla();
		}
		void TxtFiltroTextChanged(object sender, EventArgs e)
		{
			List<Archivo> listaFiltrada = new List<Archivo>();
			string filtroRapido = txtFiltro.Text;
			if (filtroRapido != null) {
				listaFiltrada = listaArchivo.FindAll(x => x.Detalle.ToLower().Contains(filtroRapido.ToLower()) || x.Fecha.Contains(filtroRapido) || x.Monto.ToString().Contains(filtroRapido));
			}else
			{
				listaFiltrada = listaArchivo;
			}
			dgvPlanilla.DataSource = null;
			dgvPlanilla.DataSource = listaFiltrada;
			dgvPlanilla.Columns["Id"].Visible = false;
		}
	
	 void desdeHasta()
	 {
	 	List<Archivo> listaFiltrada = new List<Archivo>();
	 	string filtroDesde = txtDesde.Text;
	 	string filtroHasta = txtHasta.Text;
	 	if (listaFiltrada != null) {
	 		if (filtroDesde != null) {
	 			listaFiltrada = listaArchivo.FindAll(x => x.Fecha.Contains(filtroDesde));
	 			if (filtroHasta != null) {
	 			listaFiltrada = listaArchivo.FindAll(x => x.Fecha.Contains(filtroHasta));
	 		}
	 		}else
	 		{
	 			listaFiltrada = listaArchivo;
	 		}
	 	}
		dgvPlanilla.DataSource = null;
		dgvPlanilla.DataSource = listaFiltrada;
		dgvPlanilla.Columns["Id"].Visible = false;
	 }
		void TxtDesdeTextChanged(object sender, EventArgs e)
		{
			desdeHasta();
		}

	}
}
