using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data;
using System.Linq;
using System.Security.Cryptography;
=======
using System.Linq;
>>>>>>> f0d0f94cabc31e17e767d1b489aca5e08d9ec05b
using System.Text;
using System.Threading.Tasks;
using Tp_Programacion_I.Datos;

namespace Tp_Programacion_I.Negocio
{
    public class ProyectoServicio
    {
        ProyectoDao oDao;
<<<<<<< HEAD
        AccesoDatos oBD;
=======
>>>>>>> f0d0f94cabc31e17e767d1b489aca5e08d9ec05b
        public ProyectoServicio()
        {
            oDao = new ProyectoDao();
        }
        public List<Localizacion> TraerLocalizaciones()
        {
            return oDao.RecuperarLocalizacion();
        }
<<<<<<< HEAD

        public string TraerTodosProyectos()
        {
            string consultaSQL = $@"
                                SELECT p.id_proyecto, tp.tipo_proyecto, p.nro_catastral, p.fecha_inicio, 
                                        p.fecha_final , c.nombre, ep.estado
                                FROM proyectos p
                                JOIN tipo_proyectos tp ON p.id_tipo_proyecto = tp.id_tipo_proyecto
                                JOIN clientes c ON p.id_cliente = c.id_cliente
                                JOIN estados_proyectos ep ON p.id_estado_proyecto = ep.id_estado_proyecto";
            return consultaSQL;
        }
=======
>>>>>>> f0d0f94cabc31e17e767d1b489aca5e08d9ec05b
    }
}
