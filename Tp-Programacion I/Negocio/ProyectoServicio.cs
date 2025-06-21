using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_Programacion_I.Datos;

namespace Tp_Programacion_I.Negocio
{
    public class ProyectoServicio
    {
        ProyectoDao oDao;
        public ProyectoServicio()
        {
            oDao = new ProyectoDao();
        }
        public List<Localizacion> TraerLocalizaciones()
        {
            return oDao.RecuperarLocalizacion();
        }
    }
}
