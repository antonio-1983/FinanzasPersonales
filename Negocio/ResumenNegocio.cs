using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Negocio
{
    public class ResumenNegocio
    {
        public List<Resumen> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Resumen> list = new List<Resumen>();
            try
            {
                datos.SetearQuery("select id,total_gasto,sueldo,mes,total from resumen");
                datos.Ejecutar();
                while (datos.ConexionDataReader.Read())
                {
                    Resumen aux = new Resumen();
                    aux.Id = (int)datos.ConexionDataReader["Id"];
                    aux.Total_gasto = (decimal)datos.ConexionDataReader["total_gasto"];
                    aux.Sueldo = (decimal)datos.ConexionDataReader["sueldo"];
                    aux.Total = (decimal)datos.ConexionDataReader["total"];
                    aux.Mes = (string)datos.ConexionDataReader["mes"];
                    list.Add(aux);
                }
                datos.CloseConexion();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Agregar(Resumen resumen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("insert into RESUMEN (total_gasto,total,mes, sueldo,otros_ingresos) values (@total_gasto,@total,@mes,@sueldo,@otros_ingresos) ");
                datos.setearParametro("@total_gasto", resumen.Total_gasto);
                datos.setearParametro("@total", resumen.Total);
                datos.setearParametro("@mes", resumen.Mes);
                datos.setearParametro("@sueldo", resumen.Sueldo);
                datos.setearParametro("@otros_ingresos", resumen.Otros_ingresos);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CloseConexion();
            }
        }
        public void UpdateResumen(Resumen resumen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("Update RESUMEN SET total_gasto=@total_gasto,total=@total, otros_ingresos=@otros_ingresos where mes=@mes");
                datos.setearParametro("@total_gasto", resumen.Total_gasto);
                datos.setearParametro("@total", resumen.Total);
                datos.setearParametro("@mes", resumen.Mes);
                datos.setearParametro("@otros_ingresos", resumen.Otros_ingresos);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CloseConexion();
            }
        }

        public void AgregarSueldo(decimal sueldo, string mes)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("insert into RESUMEN (sueldo,mes) values (@sueldo,@mes)");              
                datos.setearParametro("@sueldo", sueldo);
                datos.setearParametro("@mes", mes);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CloseConexion();
            }
        }
        public decimal GetSueldo(string mes)
        {
            AccesoDatos datos = new AccesoDatos();
            decimal sueldo=0;
            try
            {
                datos.SetearQuery("select sueldo from resumen where mes=@mes");
                datos.setearParametro("@mes", mes);
                datos.Ejecutar();

                while (datos.ConexionDataReader.Read())
                {
                    sueldo = (decimal)datos.ConexionDataReader["sueldo"];
                }
                datos.CloseConexion();
                return sueldo;
            }
            catch (Exception )
            {
                sueldo=0;
                return sueldo;
            }
        }
        public void UpdateSueldo(decimal sueldo, string mes)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("update RESUMEN set sueldo=@sueldo where mes=@mes");
                datos.setearParametro("@sueldo", sueldo);
                datos.setearParametro("@mes", mes);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CloseConexion();
            }
        }
    }
}
