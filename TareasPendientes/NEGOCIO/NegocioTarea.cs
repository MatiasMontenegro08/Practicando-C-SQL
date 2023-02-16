/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 11/2/2023
 * Hora: 10:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using DOMINIO;

namespace NEGOCIO
{
	/// <summary>
	/// Description of NegocioTarea.
	/// </summary>
	public class NegocioTarea
	{
		public void modificar(Tarea registro)
		{
			AccesoDatos conectar = new AccesoDatos();
			try {
				conectar.setearConsulta("update REGISTROS set detalle = @detalle where id = @id");
				conectar.setearParametro("@detalle", registro.Detalle);
				conectar.setearParametro("@id", registro.Id);
				conectar.ejecutarAccion();
			} 
			catch (Exception ex) 
			{	
				throw ex;
			}
			finally
			{
				conectar.cerrarConexion();
			}
		}
		public List<Tarea> Listar()
		{
			AccesoDatos conectar = new AccesoDatos();
			List<Tarea> listaTarea = new List<Tarea>();
			try 
			{
				conectar.setearConsulta("select id, detalle from REGISTROS");
				conectar.ejecutarLectura();
				
				while (conectar.Lector.Read()) 
				{
					Tarea aux = new Tarea();
					aux.Id = (int)conectar.Lector["id"];
					aux.Detalle = (string)conectar.Lector["detalle"];
					listaTarea.Add(aux);
				}
				return listaTarea;
			} 
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conectar.cerrarConexion();
			}
		}
		public void agregar(Tarea nuevo)
		{
			AccesoDatos conectar = new AccesoDatos();
			try 
			{
				conectar.setearConsulta("insert into REGISTROS (detalle) values (@detalle)");
				conectar.setearParametro("@detalle", nuevo.Detalle);
				conectar.ejecutarAccion();
			} 
			catch (Exception ex) 
			{	
				throw ex;
			}
			finally
			{
				conectar.cerrarConexion();
			}
		}
		public void eliminar(int seleccionado)
		{
			AccesoDatos conectar = new AccesoDatos();
			try {
				conectar.setearConsulta("delete from REGISTROS where id = @id");
				conectar.setearParametro("@id", seleccionado);
				conectar.ejecutarAccion();
			} catch (Exception ex) {
				
				throw ex;
			}
		}
	}
}
