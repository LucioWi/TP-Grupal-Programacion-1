using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_Programacion_I.Datos;
using Tp_Programacion_I.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Programacion_I
{
    public partial class FormProyectos : Form
    {
        AccesoDatos oBD;
        ProyectoServicio oServicio;
        String numCatastral;
        public FormProyectos()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            oServicio = new ProyectoServicio();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProySalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nroCatastral = txtBuscar.Text;

            if (!string.IsNullOrEmpty(nroCatastral))
            {
                CargarProyectos(nroCatastral);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número catastral válido.");
            }
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
        }
        private void CargarProyectos(string nroCatastral = null)
        {
            string consultaSQL;

            if (string.IsNullOrEmpty(nroCatastral))
            {
                consultaSQL = oServicio.TraerTodosProyectos();
            }
            else
            {
                consultaSQL = oServicio.TraerTodosProyectos() + $" WHERE p.nro_catastral = '{nroCatastral}'";
            }

            DataTable tabla = oBD.ConsultarBD(consultaSQL);
            DgvProyectos.Rows.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                DgvProyectos.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6]);
            }
        }
    }
}
