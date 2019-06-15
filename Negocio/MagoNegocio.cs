using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MagoNegocio
    {
        public List<Mago> listar()
        {
            List<Mago> lista = new List<Mago>();

            AccesoDatos accesoDatos = new AccesoDatos();
            Mago mago;
            try
            {
                accesoDatos.SetearConsulta("select Magos.Id,Nombre, Descripcion from MAGOS inner join CASAS on magos.IdCasa = CASAS.Id");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    mago = new Mago();
                    mago.Id = (int)accesoDatos.Lector["Id"];
                    mago.NombreMago = accesoDatos.Lector["Nombre"].ToString();
                    mago.casa = new Casa();
                    mago.casa.Descripcion = accesoDatos.Lector["Descripcion"].ToString();
                    lista.Add(mago);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }

    }
}
