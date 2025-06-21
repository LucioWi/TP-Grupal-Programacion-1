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
            CargarCombo(cboLocalizacion);
        }
        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = oServicio.TraerLocalizaciones();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
    }
}
