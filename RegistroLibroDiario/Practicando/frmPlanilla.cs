using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Practicando
{
    public partial class frmPlanilla : Form
    {
        Archivo archivo = null;
        ArchivoNegocio negocio = new ArchivoNegocio();
        List<Archivo> lista = new List<Archivo>();
        public frmPlanilla()
        {
            InitializeComponent();
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            cargarPlanilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevoRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarRegistro();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarRegistro();
        }

        //MÉTODOS
        private bool validarDatos()
        {
            if (txtDetalle.Text == "")
            {
                lblErrorDetalle.Text = "campo obligatorio.*";
                txtDetalle.Focus();
            }
            if (txtFecha.Text == "")
            {
                lblErrorFecha.Text = "campo obligatorio.*";
                txtFecha.Focus();
            }
            if (txtMonto.Text == "")
            {
                lblErrorMonto.Text = "campo obligatorio.*";
                txtMonto.Focus();
            }else if (!(soloNumero(txtMonto.Text)))
            {
                lblErrorMonto.Text = "ingresar solo números.*";
                txtMonto.Focus();
            }
            if (lblErrorDetalle.Text == "" && lblErrorFecha.Text == "" && lblErrorMonto.Text == "")
            {
                return false;
            }
            return true;
        }
        private void cargarPlanilla()
        {
            lista = negocio.Listar();
            dgvPlanilla.DataSource = lista;
            dgvPlanilla.Columns["Id"].Visible = false;
        }
        public void Limpiar()
        {
            txtDetalle.Text = "";
            txtFecha.Text = "";
            txtMonto.Text = "";
            rbIngreso.Checked = false;
            rbEgreso.Checked = false;
            txtDetalle.Focus();
        }
        private bool soloNumero(string cadena)
        {
            foreach (char n in cadena)
            {
                if (char.IsNumber(n))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
            if (txtDetalle.Text != "")
            {
                lblErrorDetalle.Text = "";
            }
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            if (txtFecha.Text != "")
            {
                lblErrorFecha.Text = "";
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                lblErrorMonto.Text = "";
            }
        }
        private void editarRegistro()
        {
            DialogResult respuesta = MessageBox.Show("¿Editar este registro?", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                archivo = (Archivo)dgvPlanilla.CurrentRow.DataBoundItem;
                txtDetalle.Text = archivo.Detalle;
                txtFecha.Text = archivo.Fecha;
                if (archivo.Ingreso != 0)
                {
                    txtMonto.Text = archivo.Ingreso.ToString();
                    rbIngreso.Checked = true;
                }
                else
                {
                    txtMonto.Text = archivo.Egreso.ToString();
                    rbEgreso.Checked = true;
                }
                btnActualizar.Enabled = true;
            }
        }
        private void nuevoRegistro()
        {
            try
            {
                if (validarDatos())
                {
                    return;
                }
                if (archivo == null)
                {
                    archivo = new Archivo();
                }
                archivo.Detalle = txtDetalle.Text;
                archivo.Fecha = txtFecha.Text;
                if (rbIngreso.Checked)
                {
                    archivo.Ingreso = Convert.ToDecimal(txtMonto.Text);
                }
                else
                {
                    archivo.Egreso = Convert.ToDecimal(txtMonto.Text);
                }
                negocio.Agregar(archivo);
                MessageBox.Show("Registro con éxito!");
                cargarPlanilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void actualizarRegistro()
        {
            try
            {
                if (validarDatos())
                {
                    return;
                }
                archivo = (Archivo)dgvPlanilla.CurrentRow.DataBoundItem;
                archivo.Fecha = txtFecha.Text;
                archivo.Detalle = txtDetalle.Text;
                if (rbIngreso.Checked)
                {
                    archivo.Ingreso = Convert.ToDecimal(txtMonto.Text);
                }
                else
                {
                    archivo.Egreso = Convert.ToDecimal(txtMonto.Text);
                }
                negocio.Editar(archivo);
                MessageBox.Show("Registro editado con éxito!");
                cargarPlanilla();
                Limpiar();
                btnActualizar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
