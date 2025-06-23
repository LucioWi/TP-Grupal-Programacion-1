using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_Programacion_I.Datos;

namespace Tp_Programacion_I
{
    internal class InsertarDatos
    {

        private AccesoDatos oBD = new AccesoDatos();

        private int ObtenerOInsertarId(string tabla, string campo, string valor)
        {
            AccesoDatos oBD = new AccesoDatos();

            // 1. Buscar si ya existe
            string consulta = $"SELECT id_{campo} FROM {tabla} WHERE {campo} = @valor";
            var parametros = new List<Parametro> { new Parametro("@valor", valor) };

            DataTable dt = oBD.ConsultarBD(consulta, parametros);
            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0][0]);

            // 2. Insertar si no existe
            string insert = $"INSERT INTO {tabla}({campo}) VALUES (@valor); SELECT SCOPE_IDENTITY();";
            object result = oBD.ActualizarBD(insert, parametros, true);

            return Convert.ToInt32(result);
        }
        public bool InsertarNuevoProyecto(NuevoProyecto nuevo)
        {
            try
            {
                AccesoDatos oBD = new AccesoDatos();

                // ---------- IDs directos (desde ComboBoxes) ----------
                if (!int.TryParse(nuevo.Pais, out int idPais))
                    throw new Exception("El país seleccionado no es válido.");

                if (!int.TryParse(nuevo.TipoProyecto, out int idTipoProyecto))
                    throw new Exception("El tipo de proyecto seleccionado no es válido.");

                if (!int.TryParse(nuevo.UnidadMedida, out int idUnidadMedida))
                    throw new Exception("La unidad de medida seleccionada no es válida.");

                if (!int.TryParse(nuevo.Cliente, out int idCliente))
                    throw new Exception("El cliente seleccionado no es válido.");

                if (!int.TryParse(nuevo.Estado, out int idEstado))
                    throw new Exception("El estado del proyecto no es válido.");

                if (!int.TryParse(nuevo.Etapa, out int idEtapa))
                    throw new Exception("La etapa del proyecto no es válida.");

                if (!int.TryParse(nuevo.Socios, out int idSocio))
                    throw new Exception("El socio seleccionado no es válido.");

                // ---------- IDs indirectos (desde texto) ----------
                int idProvincia = ObtenerOInsertarId("provincias", "provincia", nuevo.Provincia);
                int idCiudad = ObtenerOInsertarId("ciudades", "ciudad", nuevo.Ciudad);
                int idBarrio = ObtenerOInsertarId("barrios", "barrio", nuevo.Barrio);

                // ---------- Insertar en ubicaciones ----------
                string insertUbicacion = @"INSERT INTO ubicaciones(id_pais, id_provincia, id_ciudad) 
                                   VALUES (@pais, @provincia, @ciudad); 
                                   SELECT SCOPE_IDENTITY();";

                var parametrosUbicacion = new List<Parametro>
        {
            new Parametro("@pais", idPais),
            new Parametro("@provincia", idProvincia),
            new Parametro("@ciudad", idCiudad)
        };

                int idUbicacion = Convert.ToInt32(oBD.ActualizarBD(insertUbicacion, parametrosUbicacion, true));

                // ---------- Insertar en localizaciones ----------
                string insertLocalizacion = @"INSERT INTO localizaciones(id_ubicacion, id_barrio, calle, altura) 
                              VALUES (@idUbicacion, @idBarrio, @calle, @altura); 
                                      SELECT SCOPE_IDENTITY();";

                var parametrosLoc = new List<Parametro>
                {
                    new Parametro("@idUbicacion", idUbicacion),
                    new Parametro("@idBarrio", idBarrio), 
                    new Parametro("@calle", nuevo.Calle),
                    new Parametro("@altura", nuevo.Altura)
                };

                int idLocalizacion = Convert.ToInt32(oBD.ActualizarBD(insertLocalizacion, parametrosLoc, true));

                // ---------- Insertar en proyectos ----------
                string insertProyecto = @"INSERT INTO proyectos(id_localizacion, id_tipo_proyecto, nro_catastral, 
                                        id_unidad_medida, superficie_terreno, superficie_proyecto, 
                                        fecha_inicio, fecha_final, fecha_estimada, precio_m_cuadrado,
                                        id_cliente, id_estado_proyecto, id_etapa_proyecto)
                                  VALUES (@idLocalizacion, @tipoProy, @nroCatastral, @unidadMedida, 
                                          @supTerreno, @supProyecto, @fechaInicio, @fechaFinal, 
                                          @fechaEstimada, @precio, @cliente, @estado, @etapa);
                                  SELECT SCOPE_IDENTITY();";

                var parametrosProyecto = new List<Parametro>
        {
            new Parametro("@idLocalizacion", idLocalizacion),
            new Parametro("@tipoProy", idTipoProyecto),
            new Parametro("@nroCatastral", nuevo.NroCatastral),
            new Parametro("@unidadMedida", idUnidadMedida),
            new Parametro("@supTerreno", nuevo.Superficie),
            new Parametro("@supProyecto", nuevo.SuperficieProy),
            new Parametro("@fechaInicio", nuevo.FechaInicio),
            new Parametro("@fechaFinal", nuevo.FechaFinal),
            new Parametro("@fechaEstimada", nuevo.FechaEstimada),
            new Parametro("@precio", nuevo.Precio),
            new Parametro("@cliente", idCliente),
            new Parametro("@estado", idEstado),
            new Parametro("@etapa", idEtapa)
        };

                int idProyecto = Convert.ToInt32(oBD.ActualizarBD(insertProyecto, parametrosProyecto, true));

                // ---------- Insertar participación del socio ----------
                string insertParticipacion = @"INSERT INTO participaciones_socios(id_proyecto, id_socio)
                                       VALUES (@idProyecto, @idSocio)";
                var parametrosParti = new List<Parametro>
        {
            new Parametro("@idProyecto", idProyecto),
            new Parametro("@idSocio", idSocio)
        };

                oBD.ActualizarBD(insertParticipacion, parametrosParti);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el proyecto: " + ex.Message);
                return false;
            }
        }



    }
}
