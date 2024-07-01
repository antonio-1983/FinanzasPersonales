using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Tipo_GastoNegocio
    {
        public List<Tipo_Gasto> ListarTipo_Gasto()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Tipo_Gasto> list = new List<Tipo_Gasto>();
            try
            {
                datos.SetearQuery("select id,descripcion from tipo_gasto");
                datos.Ejecutar();
                while (datos.ConexionDataReader.Read())
                {
                    Tipo_Gasto aux = new Tipo_Gasto();
                    aux.Id = (int)datos.ConexionDataReader["Id"];
                    aux.Descripcion = (string)datos.ConexionDataReader["descripcion"];
                    list.Add(aux);
                }
                datos.CloseConexion();
                return list;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void Agregar(Tipo_Gasto tipo_gasto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("insert into tipo_gasto (descripcion) values (@descripcion)");
                datos.setearParametro("@descripcion", tipo_gasto.Descripcion);
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
                datos.SetearQuery("delete tipo_gasto where id=@id");
                datos.setearParametro("@id",id);
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
        public bool GetTipo_gasto(int id)
        {
            int idTipo = -1;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select id_tipo from gasto where id_tipo=@id");
                datos.setearParametro("@id", id);
                datos.Ejecutar();
                while (datos.ConexionDataReader.Read())
                {
                    idTipo = (int)datos.ConexionDataReader["Id_tipo"];
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (idTipo > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
