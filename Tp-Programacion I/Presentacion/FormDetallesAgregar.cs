using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_Programacion_I.Datos;
using Tp_Programacion_I.Negocio;

namespace Tp_Programacion_I
{
    public partial class FormDetallesAgregar : Form
    {
        ProyectoServicio oServicio;

        private NuevoProyecto ObtenerDatosProyecto()
        {
            return new NuevoProyecto
            {
                Codigo = txtBusqueda.Text.Trim(),
                Pais = cboPais.SelectedValue?.ToString(),
                Provincia = txtProvincia.Text.Trim(),
                Ciudad = txtCiudad.Text.Trim(),
                Barrio = txtBarrio.Text.Trim(),
                Calle = txtCalle.Text.Trim(),
                Altura = txtAltura.Text.Trim(),
                TipoProyecto = cboTipoProy.SelectedValue?.ToString(),
                NroCatastral = txtNroCatastral.Text.Trim(),
                UnidadMedida = cboUniMedida.SelectedValue?.ToString(),
                Superficie = txtSupTerreno.Text.Trim(),
                SuperficieProy = txtSupProy.Text.Trim(),
                FechaInicio = dtpFinicio.Value,
                FechaFinal = dtpFfin.Value,
                FechaEstimada = dtpFFinEst.Value,
                Precio = txtPrecio.Text.Trim(),
                Cliente = cboCliente.SelectedValue?.ToString(),
                Estado = cboEstado.SelectedValue?.ToString(),
                Etapa = cboEtapa.SelectedValue?.ToString(),
                Socios = cboSocios.SelectedValue?.ToString()
            };
        }

        public FormDetallesAgregar()
        {
            InitializeComponent();
            oServicio = new ProyectoServicio();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetalles_Load(object sender, EventArgs e)
        {
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

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            var proyecto = ObtenerDatosProyecto();

            //verificar que no haya ningun campo vacío, sino mostrar mensaje de error
            if (string.IsNullOrWhiteSpace(proyecto.Pais) || string.IsNullOrWhiteSpace(proyecto.Provincia) ||
                string.IsNullOrWhiteSpace(proyecto.Ciudad) || string.IsNullOrWhiteSpace(proyecto.Barrio) || string.IsNullOrWhiteSpace(proyecto.Calle) ||
                string.IsNullOrWhiteSpace(proyecto.Altura) || string.IsNullOrWhiteSpace(proyecto.TipoProyecto) || string.IsNullOrWhiteSpace(proyecto.NroCatastral) ||
                string.IsNullOrWhiteSpace(proyecto.Superficie) || string.IsNullOrWhiteSpace(proyecto.SuperficieProy) || string.IsNullOrWhiteSpace(proyecto.UnidadMedida) || string.IsNullOrWhiteSpace(proyecto.Precio) ||
                string.IsNullOrWhiteSpace(proyecto.Cliente) || string.IsNullOrWhiteSpace(proyecto.Estado) || string.IsNullOrWhiteSpace(proyecto.Etapa) ||
                string.IsNullOrWhiteSpace(proyecto.Socios))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                // Aquí puedes agregar la lógica para guardar el proyecto
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

                InsertarDatos insertar = new InsertarDatos();
                bool exito = insertar.InsertarNuevoProyecto(proyecto);

                if (exito)
                {
                    MessageBox.Show("Proyecto agregado correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el proyecto.");
                }

            }
        }
        

        private void LimpiarCampos()
        {
            
            cboPais.SelectedIndex = -1;
            txtProvincia.Clear();
            txtCiudad.Clear();
            txtBarrio.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            cboTipoProy.SelectedIndex = -1;
            txtNroCatastral.Clear();
            txtSupTerreno.Clear();
            dtpFinicio.Value = DateTime.Now;
            dtpFfin.Value = DateTime.Now;
            dtpFFinEst.Value = DateTime.Now;
            cboUniMedida.SelectedIndex = -1;
            txtSupProy.Clear();
            txtPrecio.Clear();
            cboCliente.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            cboEtapa.SelectedIndex = -1;
            cboSocios.SelectedIndex = -1;
        }

    }
}
