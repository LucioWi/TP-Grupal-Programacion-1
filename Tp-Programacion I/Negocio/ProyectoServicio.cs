using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tp_Programacion_I.Datos;

namespace Tp_Programacion_I.Negocio
{
    public class ProyectoServicio
    {
        ProyectoDao oDao;
        AccesoDatos oBD;
        public ProyectoServicio()
        {
            oDao = new ProyectoDao();
        }
        public string TraerTodosProyectos()
        {
            string consultaSQL = $@"
                                SELECT DISTINCT p.id_proyecto, tp.tipo_proyecto, p.nro_catastral, p.fecha_inicio, 
                                        p.fecha_final , c.nombre, ep.estado
                                FROM proyectos p
                                JOIN tipo_proyectos tp ON p.id_tipo_proyecto = tp.id_tipo_proyecto
                                JOIN clientes c ON p.id_cliente = c.id_cliente
                                JOIN estados_proyectos ep ON p.id_estado_proyecto = ep.id_estado_proyecto";
            return consultaSQL;
        }
        public List<Pais> TraerPaises()
        {
            return oDao.RecuperarPais();
        }
        public List<TipoProyectos> TraerTipoProyectos()
        {
            return oDao.RecuperarTipoProyectos();
        }

        public List<UnidadMedida> TraerUnidadMedida()
        {
            return oDao.RecuperarUnidadMedida();
        }

        public List<Cliente> TraerClientes()
        {
            return oDao.RecuperarCliente();
        }

        public List<Estado> TraerEstados()
        {
            return oDao.RecuperarEstado();
        }

        public List<Etapa> TraerEtapas()
        {
            return oDao.RecuperarEtapa();
        }

        public List<Socio> TraerSocios()
        {
            return oDao.RecuperarSocio();
        }
    }
}
