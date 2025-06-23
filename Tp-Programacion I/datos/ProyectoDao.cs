using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_Programacion_I.Datos;
using Tp_Programacion_I.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tp_Programacion_I.Datos
{
    public class ProyectoDao
    {
        AccesoDatos oBD;
        public ProyectoDao() 
        { 
            oBD = new AccesoDatos();
        }

        public List<Pais> RecuperarPais()
        {
            List<Pais> Lista = new List<Pais>();
            DataTable tabla = oBD.ConsultarTabla("paises");
            foreach (DataRow fila in tabla.Rows)
            {
                Pais oLocalizacion = new Pais();
                oLocalizacion.Codigo = (int)fila["id_pais"];
                oLocalizacion.Paises = fila["pais"].ToString();
                Lista.Add(oLocalizacion);
            }
            return Lista;
        }

        public List<TipoProyectos> RecuperarTipoProyectos()
        {
            List<TipoProyectos> Lista = new List<TipoProyectos> ();
            DataTable tabla = oBD.ConsultarTabla("tipo_proyectos");
            foreach (DataRow fila in tabla.Rows)
            {
                TipoProyectos oTipoProyectos = new TipoProyectos();
                oTipoProyectos.Codigo = (int)fila["id_tipo_proyecto"];
                oTipoProyectos.Tipo = fila["tipo_proyecto"].ToString();
                Lista.Add (oTipoProyectos);
            }
            return Lista;
        }

        public List<UnidadMedida> RecuperarUnidadMedida()
        {
            List<UnidadMedida> Lista = new List<UnidadMedida>();
            DataTable tabla = oBD.ConsultarTabla("unidades_medidas");
            foreach (DataRow fila in tabla.Rows)
            {
                UnidadMedida oUnidadMedida = new UnidadMedida();
                oUnidadMedida.Codigo = (int)fila["id_unidad_medida"];
                oUnidadMedida.Medida = fila["medida"].ToString();
                Lista.Add(oUnidadMedida);
            }
            return Lista;
        }

        public List<Cliente> RecuperarCliente()
        {
            List<Cliente> Lista = new List<Cliente>();
            DataTable tabla = oBD.ConsultarTabla("clientes");
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente oCliente = new Cliente();
                oCliente.Codigo = (int)fila["id_cliente"];
                oCliente.Nombre = fila["nombre"].ToString();
                Lista.Add(oCliente);
            }
            return Lista;
        }

        public List<Estado> RecuperarEstado()
        {
            List<Estado> Lista = new List<Estado>();
            DataTable tabla = oBD.ConsultarTabla("estados_proyectos");
            foreach (DataRow fila in tabla.Rows)
            {
                Estado oEstado = new Estado();
                oEstado.Codigo = (int)fila["id_estado_proyecto"];
                oEstado.EstadoProyecto= fila["estado"].ToString();
                Lista.Add(oEstado);
            }
            return Lista;
        }

        public List<Etapa> RecuperarEtapa()
        {
            List<Etapa> Lista = new List<Etapa>();
            DataTable tabla = oBD.ConsultarTabla("etapas_proyectos");
            foreach (DataRow fila in tabla.Rows)
            {
                Etapa oEtapa = new Etapa();
                oEtapa.Codigo = (int)fila["id_etapa_proyecto"];
                oEtapa.EtapaProyecto = fila["etapa_proyecto"].ToString();
                Lista.Add(oEtapa);
            }
            return Lista;
        }

        public List<Socio> RecuperarSocio()
        {
            List<Socio> Lista = new List<Socio>();
            DataTable tabla = oBD.ConsultarTabla("socios");
            foreach (DataRow fila in tabla.Rows)
            {
                Socio oSocio = new Socio();
                oSocio.Codigo = (int)fila["id_socio"];
                oSocio.Nombre = fila["nombre"].ToString();
                Lista.Add(oSocio);
            }
            return Lista;
        }
    }
}
