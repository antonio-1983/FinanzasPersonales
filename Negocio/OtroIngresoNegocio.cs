using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class OtroIngresoNegocio
    {
        public List<OtroIngreso> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<OtroIngreso> list = new List<OtroIngreso>();
            try
            {
                datos.SetearQuery("SELECT id,descripcion,importe,fecha,mes FROM OTROS_INGRESOS where mes=@mes");
                datos.setearParametro("@mes", DateTime.Now.ToString("MMMM").ToUpper());
                datos.Ejecutar();
                while (datos.ConexionDataReader.Read())
                {
                    OtroIngreso aux = new OtroIngreso();
                    aux.Id = (int)datos.ConexionDataReader["Id"];
                    aux.Descripcion = (string)datos.ConexionDataReader["descripcion"];
                    aux.Importe = (decimal)datos.ConexionDataReader["importe"];
                    aux.Fecha = (string)datos.ConexionDataReader["fecha"];
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
        public decimal TotalOtrosIngresos()
        {
            AccesoDatos datos = new AccesoDatos();
            decimal totalGasto = 0;
            try
            {
                datos.SetearQuery("select sum(importe) totalOtrosIngresos from OTROS_INGRESOS where mes=@mes");
                datos.setearParametro("@mes", DateTime.Now.ToString("MMMM").ToUpper());
                datos.Ejecutar();
                
                while (datos.ConexionDataReader.Read())
                {
                    totalGasto = (decimal)datos.ConexionDataReader["totalOtrosIngresos"];
                }
                datos.CloseConexion();
                return totalGasto;   
            }
            catch (Exception)
            {
                totalGasto=0;
                return totalGasto;
            }
        }
        public void Agregar(OtroIngreso otroIngreso)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearQuery("insert into OTROS_INGRESOS (descripcion,importe,fecha,mes) values (@descripcion,@importe,@fecha,@mes)");
                datos.setearParametro("@descripcion", otroIngreso.Descripcion);
                datos.setearParametro("@importe", otroIngreso.Importe);
                datos.setearParametro("@fecha", otroIngreso.Fecha);
                datos.setearParametro("@mes", otroIngreso.Mes);
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
        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("delete OTROS_INGRESOS where id=@id");
                datos.setearParametro("@id", id);
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
