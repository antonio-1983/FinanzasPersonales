using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Negocio
{
    public class GastoNegocio
    {
        public List<Gasto> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Gasto> list = new List<Gasto>();
            try
            {
                datos.SetearQuery("select  g.id, g.descripcion, g.id_tipo, t.descripcion tipo_gasto,g.importe, g.mes, g.fecha from gasto g left join TIPO_GASTO  t on id_tipo=t.id where mes=@mes");
                datos.setearParametro("@mes", DateTime.Now.ToString("MMMM").ToUpper());
                datos.Ejecutar();
                while (datos.ConexionDataReader.Read())
                {
                    Gasto aux = new Gasto();
                    aux.Id = (int)datos.ConexionDataReader["Id"];
                    aux.Descripcion = (string)datos.ConexionDataReader["descripcion"];
                    aux.Tipo_gasto = new Tipo_Gasto();
                    aux.Tipo_gasto.Id = (int)datos.ConexionDataReader["id_tipo"];
                    aux.Tipo_gasto.Descripcion = (string)datos.ConexionDataReader["tipo_gasto"];
                    aux.Importe = (decimal)datos.ConexionDataReader["importe"];
                    aux.Fecha = (int)datos.ConexionDataReader["fecha"];
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

        public decimal TotalGasto()
        {
            AccesoDatos datos = new AccesoDatos();
            decimal totalGasto = 0;
            try
            {
                datos.SetearQuery("select sum(importe) totalGasto from GASTO where mes=@mes");
                datos.setearParametro("@mes", DateTime.Now.ToString("MMMM").ToUpper());
                datos.Ejecutar();
                while (datos.ConexionDataReader.Read())
                {
                    totalGasto = (decimal)datos.ConexionDataReader["totalGasto"];
                }
                datos.CloseConexion();
                return totalGasto;
            }
            catch (Exception)
            {
                totalGasto = 0;
                return totalGasto;
            }
        }
        public void Agregar(Gasto gasto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("insert into gasto (descripcion,importe,mes,fecha,id_tipo) values (@descripcion,@importe,@mes,@fecha,@id_tipo)");
                datos.setearParametro("@descripcion", gasto.Descripcion);
                datos.setearParametro("@importe", gasto.Importe);
                datos.setearParametro("@mes", gasto.Mes);
                datos.setearParametro("@fecha", gasto.Fecha);
                datos.setearParametro("@id_tipo", gasto.Tipo_gasto.Id);
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
                datos.SetearQuery("delete from gasto where id=@id");
                datos.setearParametro("@id", id);
                datos.Ejecutar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
