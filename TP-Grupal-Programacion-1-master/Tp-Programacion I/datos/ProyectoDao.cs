using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_Programacion_I.Datos;
using Tp_Programacion_I.Negocio;

namespace Tp_Programacion_I.Datos
{
    public class ProyectoDao
    {
        AccesoDatos oBD;
        public ProyectoDao() 
        { 
            oBD = new AccesoDatos();
        }

        public List<Localizacion> RecuperarLocalizacion()
        {
            List<Localizacion> Lista = new List<Localizacion>();
            DataTable tabla = oBD.ConsultarTabla("localizaciones");
            foreach (DataRow fila in tabla.Rows)
            {
                Localizacion oLocalizacion = new Localizacion();
                oLocalizacion.Codigo = (int)fila["id_localizacion"];
                oLocalizacion.Ubicacion = (int)fila["id_ubicacion"];
                oLocalizacion.Barrio = (int)fila["id_barrio"];
                oLocalizacion.Calle = fila["calle"].ToString();
                Lista.Add(oLocalizacion);
            }
            return Lista;
        }
    }
}
