using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
<<<<<<< HEAD
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_Programacion_I.Datos;
using Tp_Programacion_I.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
=======
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> f0d0f94cabc31e17e767d1b489aca5e08d9ec05b

namespace Tp_Programacion_I
{
    public partial class FormProyectos : Form
    {
<<<<<<< HEAD
        AccesoDatos oBD;
        ProyectoServicio ps;
        String numCatastral;
        public FormProyectos()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            ps = new ProyectoServicio();

        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nroCatastral = txtBuscar.Text;

            if (!string.IsNullOrEmpty(nroCatastral))
            {
                CargarProyectos(nroCatastral);
            }
            else{
                MessageBox.Show("Por favor, ingrese un número catastral válido.");
            }
        }

        private void CargarProyectos(string nroCatastral = null)
        {
            string consultaSQL;

            if (string.IsNullOrEmpty(nroCatastral)) 
            {
                consultaSQL = ps.TraerTodosProyectos();
            }
            else 
            {
                consultaSQL = ps.TraerTodosProyectos() + $" WHERE p.nro_catastral = '{nroCatastral}'";
            }

            DataTable tabla = oBD.ConsultarBD(consultaSQL);
            dgvProyectos.Rows.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                dgvProyectos.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6]);
            }
        }
=======
        public FormProyectos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

>>>>>>> f0d0f94cabc31e17e767d1b489aca5e08d9ec05b
        private void btnProySalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD

=======
>>>>>>> f0d0f94cabc31e17e767d1b489aca5e08d9ec05b
    }
}
