/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 4/2/2023
 * Hora: 09:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data.SqlClient;

namespace Negocio
{
	/// <summary>
	/// Description of AccesoDatos.
	/// </summary>
	public class AccesoDatos
	{
		private SqlConnection conexion;
		private SqlCommand comando;
		private SqlDataReader lector;
		public SqlDataReader Lector
		{
			get	{ return lector; }
		}
		public AccesoDatos()
		{
			conexion = new SqlConnection("server=.\\SQLEXPRESS01; database=PracticasProjectos; integrated security=true");
			comando = new SqlCommand();
		}
		public void setearConsulta(string consulta)
		{
			comando.CommandType = System.Data.CommandType.Text;
			comando.CommandText = consulta;
		}
		public void ejecutarLectura()
		{
			comando.Connection = conexion;
			try 
			{
				conexion.Open();
				lector = comando.ExecuteReader();
			} 
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void cerrarConexion()
		{
			if (lector != null) 
			{
				lector.Close();
				conexion.Close();
			}
		}
		public void ejecutarAccion()
		{
			comando.Connection = conexion;
			try 
			{
				conexion.Open();
				comando.ExecuteNonQuery();
			} 
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void setearParametro(string nombre, object nuevo)
		{
			comando.Parameters.AddWithValue(nombre, nuevo);
		}
	}
}
