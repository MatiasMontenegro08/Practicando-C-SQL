using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArchivoNegocio
    {
        public void Agregar(Archivo archivo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into LibroDiario (Detalle, Fecha, Ingreso, Egreso) values (@Detalle, @Fecha, @Ing, @Egr)");
                datos.setearParametro("@Detalle", archivo.Detalle);
                datos.setearParametro("@Fecha", archivo.Fecha);
                datos.setearParametro("@Ing", archivo.Ingreso);
                datos.setearParametro("@Egr", archivo.Egreso);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }
        public void Editar(Archivo archivo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update LibroDiario set Detalle = @Deta, Fecha = @Fecha, Ingreso = @Ing, Egreso = @Egr where Id = @Id");
                datos.setearParametro("@Deta", archivo.Detalle);
                datos.setearParametro("@Fecha", archivo.Fecha);
                datos.setearParametro("@Ing", archivo.Ingreso);
                datos.setearParametro("@Egr", archivo.Egreso);
                datos.setearParametro("@Id", archivo.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Archivo> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Archivo> registro = new List<Archivo>();
            try
            {
                datos.setearConsulta("select * from LibroDiario");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Archivo nota = new Archivo();
                    nota.Id = (int)datos.Lector["Id"];
                    nota.Detalle = (string)datos.Lector["Detalle"];
                    nota.Fecha = (string)datos.Lector["Fecha"];
                    nota.Ingreso = (double)datos.Lector["Ingreso"];
                    nota.Egreso = (double)datos.Lector["Egreso"];
                    registro.Add(nota);
                }
                return registro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
