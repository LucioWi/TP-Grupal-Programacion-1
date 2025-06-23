using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_Programacion_I.Negocio;
using Tp_Programacion_I.Datos;

namespace Tp_Programacion_I
{
    public partial class FormDetalles : Form
    {
        ProyectoServicio oServicio;
        public FormDetalles()
        {
            InitializeComponent();
            oServicio = new ProyectoServicio();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
