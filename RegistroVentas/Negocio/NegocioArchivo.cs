/*
 * Creado por SharpDevelop.
 * Usuario: Matias
 * Fecha: 4/2/2023
 * Hora: 09:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data.SqlTypes;
using System.Collections.Generic;
using Dominio;

namespace Negocio
{
	/// <summary>
	/// Description of NegocioArchivo.
	/// </summary>
	public class NegocioArchivo
	{
		public void Agregar(Archivo registro)
		{
			AccesoDatos conectar = new AccesoDatos();
			try 
			{
					conectar.setearConsulta("insert into Venta (fecha, detalle, monto) values (@fecha, @detalle, @monto)");
					conectar.setearParametro("@fecha", registro.Fecha);
					conectar.setearParametro("@detalle", registro.Detalle);
					conectar.setearParametro("@monto", registro.Monto);
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

		public List<Archivo> Listar()
		{
			List<Archivo> lista = new List<Archivo>();
			AccesoDatos conectar = new AccesoDatos();
			try 
			{
				conectar.setearConsulta("select id, fecha, detalle, monto from Venta");
				conectar.ejecutarLectura();
				while (conectar.Lector.Read()) 
				{
					Archivo temporal = new Archivo();
					temporal.Id = (int)conectar.Lector["id"];
					temporal.Fecha = (string)conectar.Lector["fecha"];
					temporal.Detalle = (string)conectar.Lector["detalle"];
					temporal.Monto = (decimal)conectar.Lector["monto"];
//					double precio = Convert.ToDouble(temporal.Monto);
//					temporal.Precio = precio;
					lista.Add(temporal);
				}
				return lista;
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
		public void EliminarRegistro(Archivo seleccionado)
		{
			try 
			{
				AccesoDatos datos = new AccesoDatos();
				datos.setearConsulta("delete from Venta where id = @id");
				datos.setearParametro("@id", seleccionado.Id);
				datos.ejecutarAccion();
			} 
			catch (Exception ex) 
			{
				throw ex;
			}
		}
		public void Editar(Archivo seleccionado)
		{
			try {
				AccesoDatos datos = new AccesoDatos();
				datos.setearConsulta("update Venta set fecha = @fecha, detalle = @detalle, monto = @monto where id = @id");
				datos.setearParametro("@fecha", seleccionado.Fecha);
				datos.setearParametro("@detalle", seleccionado.Detalle);
				datos.setearParametro("@monto", seleccionado.Monto);
				datos.setearParametro("@id", seleccionado.Id);
				datos.ejecutarAccion();
			} catch (Exception ex) {
				
				throw ex;
			}
		}
	}
}
