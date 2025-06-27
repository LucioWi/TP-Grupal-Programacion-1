using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            oBD = new AccesoDatos();
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
        public void BorrarProyecto(string idProyecto)
        {
            string consultaSQL =
                "DELETE FROM detalles_facturados WHERE id_proyecto = " + idProyecto.ToString() + ";" +
                "DELETE FROM facturas WHERE id_factura IN (" +
                    "SELECT f.id_factura FROM facturas f " +
                    "LEFT JOIN detalles_facturados df ON f.id_factura = df.id_factura " +
                    "WHERE df.id_factura IS NULL" +
                ");" +
                "DELETE FROM participaciones_socios WHERE id_proyecto = " + idProyecto.ToString() + ";" +
                "DELETE FROM proyectos WHERE id_proyecto = " + idProyecto.ToString() + ";";


            oBD.ActualizarBDChica(consultaSQL);
        }
        public string TraerCodigoProyecto(string numCatastral)
        {
            string consultaSql = "SELECT id_proyecto FROM proyectos WHERE nro_catastral = " + numCatastral.ToString() + ";";

            DataTable tablaCodigos = oBD.ConsultasRelacionadas(consultaSql);
            DataRow fila = tablaCodigos.Rows[0];


            string valorCodigo = fila["id_proyecto"].ToString();
            return valorCodigo;

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
