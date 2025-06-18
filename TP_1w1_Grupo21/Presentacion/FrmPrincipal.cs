using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1w1_Grupo21
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmProyectos fp = new FrmProyectos();
            fp.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmDetalles fd = new FrmDetalles();
            fd.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", " Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
    }
}
