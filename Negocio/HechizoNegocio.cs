using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;


namespace Negocio
{
    public class HechizoNegocio
    {
        public List<Hechizo> listar()
        {
            List<Hechizo> lista = new List<Hechizo>();

            AccesoDatos accesoDatos = new AccesoDatos();
            Hechizo hechizo;
            try
            {
                accesoDatos.SetearConsulta("select hechizos.Id,nombre,descripcion from HECHIZOS inner join HECHIZOSMAGOS on HECHIZOS.Id = HECHIZOSMAGOS.IdHechizo");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    hechizo = new Hechizo();
                    hechizo.IdHechizo = (int)accesoDatos.Lector["Id"];
                    hechizo.NombreHechizo = accesoDatos.Lector["Nombre"].ToString();
                    hechizo.Descripcion = accesoDatos.Lector["Descripcion"].ToString();
                    lista.Add(hechizo);
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
