/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 11/2/2023
 * Hora: 11:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using DOMINIO;
using NEGOCIO;

namespace PRESENTACION
{
	/// <summary>
	/// Description of frmRegistro.
	/// </summary>
	public partial class frmRegistro : Form
	{
		NegocioTarea negocio = new NegocioTarea();
		Tarea registro = null;
		public frmRegistro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public frmRegistro(Tarea seleccionado)
		{
			InitializeComponent();
			registro = seleccionado;
			Text = "EDITAR TAREA";
			txtTarea.Text = registro.Detalle;
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
			try 
			{
				if (registro == null)
				{
					registro = new Tarea();
				}
				registro.Detalle = txtTarea.Text;
				if (registro.Id != 0) {
					negocio.modificar(registro);
					MessageBox.Show("Registro modificado!");
				}else
				{
					negocio.agregar(registro);
					MessageBox.Show("Registro agregado!");
				}
				Close();
			} 
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
