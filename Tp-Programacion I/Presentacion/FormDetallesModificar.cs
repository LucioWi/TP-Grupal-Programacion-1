using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_Programacion_I.Datos;
using Tp_Programacion_I.Negocio;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Tp_Programacion_I.Presentacion
{
    public partial class FormDetallesModificar : Form
    {
        private string numeroCatastral;
        AccesoDatos oBD;
        ProyectoServicio oServicio;
        private SqlConnection conexion;
        public FormDetallesModificar(string numCatastral)
        {
            InitializeComponent();
            numeroCatastral = numCatastral;
            oBD = new AccesoDatos();
            oServicio = new ProyectoServicio();
        }

        private void FormDetallesModificar_Load(object sender, EventArgs e) {
            txtBusqueda.Text = numeroCatastral;
            CargarCombo(cboPais);
            CargarCombo(cboTipoProy);
            CargarCombo(cboUniMedida);
            CargarCombo(cboCliente);
            CargarCombo(cboEstado);
            CargarCombo(cboEtapa);
            CargarCombo(cboSocios);
        }
        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = null;
            combo.Items.Clear();

            if (combo == cboPais)
            {
                combo.DataSource = oServicio.TraerPaises()
                    .GroupBy(l => l.Paises) // Asegura que no haya duplicados por Código
                    .Select(g => g.First())
                    .ToList();
                combo.DisplayMember = "Paises";
                combo.ValueMember = "Codigo";
            }

            if (combo == cboTipoProy)
            {
                combo.DataSource = oServicio.TraerTipoProyectos()
                    .GroupBy(l => l.Tipo) // Asegura que no haya duplicados por Código
                    .Select(g => g.First())
                    .ToList();
                combo.DisplayMember = "Tipo";
                combo.ValueMember = "Codigo";
            }
            if (combo == cboUniMedida)
            {
                combo.DataSource = oServicio.TraerUnidadMedida()
                    .GroupBy(l => l.Medida) // Asegura que no haya duplicados por Código
                    .Select(g => g.First())
                    .ToList();
                combo.DisplayMember = "Medida";
                combo.ValueMember = "Codigo";
            }
            if (combo == cboCliente)
            {
                combo.DataSource = oServicio.TraerClientes()
                    .GroupBy(l => l.Nombre) // Asegura que no haya duplicados por Código
                    .Select(g => g.First())
                    .ToList();
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Codigo";
            }
            if (combo == cboEstado)
            {
                combo.DataSource = oServicio.TraerEstados()
                    .GroupBy(l => l.EstadoProyecto) // Asegura que no haya duplicados por Código
                    .Select(g => g.First())
                    .ToList();
                combo.DisplayMember = "EstadoProyecto";
                combo.ValueMember = "Codigo";
            }
            if (combo == cboEtapa)
            {
                combo.DataSource = oServicio.TraerEtapas()
                    .GroupBy(l => l.EtapaProyecto) // Asegura que no haya duplicados por Código
                    .Select(g => g.First())
                    .ToList();
                combo.DisplayMember = "EtapaProyecto";
                combo.ValueMember = "Codigo";
            }
            if (combo == cboSocios)
            {
                combo.DataSource = oServicio.TraerSocios()
                    .GroupBy(l => l.Nombre) // Asegura que no haya duplicados por Código
                    .Select(g => g.First())
                    .ToList();
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Codigo";
            }
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string numCatas = txtBusqueda.Text;
            DataRow filaProyectos = null;
            DataRow filaParticipacion = null;

            DataTable tablaProyectos = oBD.ConsultasRelacionadas("SELECT * FROM proyectos WHERE nro_catastral = " + numCatas + ";");
            if (tablaProyectos.Rows.Count > 0)
            {
                filaProyectos = tablaProyectos.Rows[0];
                // Proceed with further processing
            }
            else
            {
                MessageBox.Show("No se encontraron proyectos con el número catastral especificado.");
                return;
            }

            DataTable tablaParticipacion = oBD.ConsultasRelacionadas("SELECT ps.* FROM participaciones_socios ps JOIN proyectos p ON ps.id_proyecto = p.id_proyecto " +
                                                                     "WHERE p.nro_catastral = " + numCatas + ";");
            if (tablaParticipacion.Rows.Count > 0)
            {
                filaParticipacion = tablaParticipacion.Rows[0];
                cboSocios.SelectedValue = filaParticipacion["id_socio"];
                // Usá filaParticipacion con seguridad acá
            }
            else
            {
                MessageBox.Show("No se encontró participación asociada al proyecto.");
            }

            DataTable tablaUbicacion = oBD.ConsultasRelacionadas("SELECT u.* FROM ubicaciones u " +
                "JOIN localizaciones l ON u.id_ubicacion = l.id_ubicacion JOIN proyectos p ON l.id_localizacion = p.id_localizacion WHERE nro_catastral = " + numCatas + ";");
            DataRow filaUbicacion = tablaUbicacion.Rows[0];

            DataTable tablaLocalizacion = oBD.ConsultasRelacionadas("SELECT l.* FROM localizaciones l JOIN proyectos p ON p.id_localizacion = l.id_localizacion " +
                                                                    "WHERE nro_catastral = " + numCatas + ";");
            DataRow filaLocalizacion = tablaLocalizacion.Rows[0];


            cboPais.SelectedValue = filaUbicacion["id_pais"];

            txtProvincia.Text = filaUbicacion["id_provincia"].ToString();
            txtCiudad.Text = filaUbicacion["id_ciudad"].ToString();
            txtBarrio.Text = filaLocalizacion["id_barrio"].ToString();
            txtCalle.Text = filaLocalizacion["calle"].ToString();
            txtAltura.Text = filaLocalizacion["altura"].ToString();

            cboTipoProy.SelectedValue = filaProyectos["id_tipo_proyecto"];

            txtNroCatastral.Text = filaProyectos["nro_catastral"].ToString();

            cboUniMedida.SelectedValue = filaProyectos["id_unidad_medida"];

            txtSupTerreno.Text = filaProyectos["superficie_terreno"].ToString();
            txtSupProy.Text = filaProyectos["superficie_proyecto"].ToString();

            dtpFinicio.Value = (DateTime)filaProyectos["fecha_inicio"];
            if (filaProyectos["fecha_final"] == DBNull.Value)
            {
                chboxHabFechaFinalEdit.Checked = false;
                dtpFfin.Enabled = false;
                // Opcional: puedes poner una fecha por defecto si quieres
                // dtpFfin.Value = DateTime.Now;
            }
            else
            {
                chboxHabFechaFinalEdit.Checked = true;
                dtpFfin.Enabled = true;
                dtpFfin.Value = (DateTime)filaProyectos["fecha_final"];
            }
            dtpFFinEst.Value = (DateTime)filaProyectos["fecha_estimada"];

            txtPrecio.Text = filaProyectos["precio_m_cuadrado"].ToString();
            cboCliente.SelectedValue = filaProyectos["id_cliente"];
            cboEstado.SelectedValue = filaProyectos["id_unidad_medida"];
            cboEtapa.SelectedValue = filaProyectos["id_etapa_proyecto"];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                double nroCatastral = Convert.ToDouble(txtNroCatastral.Text);
                double supTerreno = Convert.ToDouble(txtSupTerreno.Text);
                double supProy = Convert.ToDouble(txtSupProy.Text);
                double precio = Convert.ToDouble(txtPrecio.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double barrio = Convert.ToDouble(txtBarrio.Text);
                double provincia = Convert.ToDouble(txtProvincia.Text);
                double ciudad = Convert.ToDouble(txtCiudad.Text);

                // Por ejemplo, validar rango si querés:
                if (nroCatastral < int.MinValue || nroCatastral > int.MaxValue)
                    throw new OverflowException("NroCatastral fuera de rango.");
                // Similar para los demás si es necesario
            }
            catch (FormatException)
            {
                MessageBox.Show("Los campos NroCatastral, SupTerreno, SupProy, Precio, Altura, Barrio, Provincia y Ciudad deben contener números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Alguno de los campos NroCatastral, SupTerreno, SupProy, Precio, Altura, Barrio, Provincia o Ciudad es demasiado grande o pequeño.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Error aritmético al procesar los campos NroCatastral, SupTerreno, SupProy, Precio, Altura, Barrio, Provincia o Ciudad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpFinicio.Value >= dtpFFinEst.Value || dtpFinicio.Value >= dtpFfin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor o igual que la fecha de fin estimada ni que la fecha de fin.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AccesoDatos oBD = new AccesoDatos();
            string CadenaConexion = oBD.CadenaConexion;
            conexion = new SqlConnection(CadenaConexion);
            string numCatas = txtNroCatastral.Text.Trim();

            if (string.IsNullOrWhiteSpace(cboPais.SelectedValue?.ToString()) || string.IsNullOrWhiteSpace(txtProvincia.Text) || string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtBarrio.Text) || string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtAltura.Text) ||
                string.IsNullOrWhiteSpace(cboTipoProy.SelectedValue?.ToString()) || string.IsNullOrWhiteSpace(txtNroCatastral.Text) || string.IsNullOrWhiteSpace(txtSupTerreno.Text) ||
                string.IsNullOrWhiteSpace(txtSupProy.Text) || string.IsNullOrWhiteSpace(cboUniMedida.SelectedValue?.ToString()) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(cboEtapa.SelectedValue?.ToString()))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // UPDATE ubicaciones
            string updateUbicacion = @"
                                    UPDATE u
                                    SET 
                                        u.id_pais = @pais,
                                        u.id_provincia = @provincia,
                                        u.id_ciudad = @ciudad
                                    FROM ubicaciones u
                                    JOIN localizaciones l ON u.id_ubicacion = l.id_ubicacion
                                    JOIN proyectos p ON l.id_localizacion = p.id_localizacion
                                    WHERE p.nro_catastral = @numCatastral;";

            conexion.Open();
            using (SqlCommand cmd = new SqlCommand(updateUbicacion, conexion))
            {
                cmd.Parameters.AddWithValue("@pais", cboPais.SelectedValue);
                cmd.Parameters.AddWithValue("@provincia", txtProvincia.Text.Trim());
                cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                cmd.Parameters.AddWithValue("@numCatastral", numCatas);

                cmd.ExecuteNonQuery();
            }
            

            // UPDATE localizaciones
            string updateLocalizacion = @"
                            UPDATE l
                            SET
                                l.id_barrio = @idBarrio,
                                l.calle = @calle,
                                l.altura = @altura
                            FROM localizaciones l
                            JOIN proyectos p ON p.id_localizacion = l.id_localizacion
                            WHERE p.nro_catastral = @numCatastral;";

            using (SqlCommand cmd = new SqlCommand(updateLocalizacion, conexion))
            {
                cmd.Parameters.AddWithValue("@idBarrio", txtBarrio.Text.Trim());
                cmd.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
                cmd.Parameters.AddWithValue("@altura", txtAltura.Text.Trim());
                cmd.Parameters.AddWithValue("@numCatastral", numCatas);

                cmd.ExecuteNonQuery();
            }



            string updateProyecto = @"
                            UPDATE proyectos
                            SET 
                                id_tipo_proyecto = @tipoProy,
                                nro_catastral = @nroCatastral,
                                id_unidad_medida = @unidadMedida,
                                superficie_terreno = @supTerreno,
                                superficie_proyecto = @supProyecto,
                                fecha_inicio = @fechaInicio,
                                fecha_final = @fechaFinal,
                                fecha_estimada = @fechaEstimada,
                                precio_m_cuadrado = @precio,
                                id_cliente = @cliente,
                                id_estado_proyecto = @estado,
                                id_etapa_proyecto = @etapa
                            WHERE nro_catastral = @numCatastral;";

            using (SqlCommand comando = new SqlCommand(updateProyecto, conexion))
            {
                comando.Parameters.AddWithValue("@tipoProy", cboTipoProy.SelectedValue);
                comando.Parameters.AddWithValue("@nroCatastral", Convert.ToInt32(txtNroCatastral.Text));
                comando.Parameters.AddWithValue("@unidadMedida", cboUniMedida.SelectedValue);
                comando.Parameters.AddWithValue("@supTerreno", Convert.ToDecimal(txtSupTerreno.Text));
                comando.Parameters.AddWithValue("@supProyecto", Convert.ToDecimal(txtSupProy.Text));
                comando.Parameters.AddWithValue("@fechaInicio", dtpFinicio.Value);
                comando.Parameters.AddWithValue("@fechaFinal", dtpFfin.Value);
                comando.Parameters.AddWithValue("@fechaEstimada", dtpFFinEst.Value);
                comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                comando.Parameters.AddWithValue("@cliente", cboCliente.SelectedValue);
                comando.Parameters.AddWithValue("@estado", cboEstado.SelectedValue);
                comando.Parameters.AddWithValue("@etapa", cboEtapa.SelectedValue);
                comando.Parameters.AddWithValue("@numCatastral", numCatas);

                comando.ExecuteNonQuery();
            }


            string updateParticipacion = @"
                                UPDATE ps
                                SET ps.id_socio = @idSocio
                                FROM participaciones_socios ps
                                JOIN proyectos p ON ps.id_proyecto = p.id_proyecto
                                WHERE p.nro_catastral = @numCatastral;";

            using (SqlCommand comando = new SqlCommand(updateParticipacion, conexion))
            {
                comando.Parameters.AddWithValue("@idSocio", cboSocios.SelectedValue);
                comando.Parameters.AddWithValue("@numCatastral", numCatas);

                comando.ExecuteNonQuery();
            }
            conexion.Close();

            MessageBox.Show("Proyecto modificado correctamente.");
        }

        private void chboxHabFechaFinalEdit_CheckedChanged(object sender, EventArgs e)
        {
            dtpFfin.Enabled = chboxHabFechaFinalEdit.Checked;
        }
        private void soloNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void soloNumericoyComas_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && (txt.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }
    }
}
