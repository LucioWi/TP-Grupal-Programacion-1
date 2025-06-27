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
using Tp_Programacion_I.Presentacion;
using Tp_Programacion_I.Datos;

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

        private void btnProySalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nroCatastral = txtBuscar.Text.Trim();
            bool esNumero = int.TryParse(nroCatastral, out int numero);

            if (string.IsNullOrWhiteSpace(nroCatastral))
            {
                CargarProyectos(); // Si no se ingresa un número catastral, carga todos los proyectos
                return;
            }
            if (esNumero == false)
            {
                MessageBox.Show("Numero catastral tiene que ser un numero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verificamos si existe el nroCatastral en la base de datos
            string consultaSQL = oServicio.TraerTodosProyectos() + $" WHERE p.nro_catastral = '{nroCatastral}'";
            DataTable resultado = oBD.ConsultarBD(consultaSQL);

            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron proyectos con el número catastral ingresado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CargarProyectos(nroCatastral); // Solo carga si hay datos
            }
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
        }

        private void CargarProyectos(string nroCatastral = null)
        {
            string consultaSQL;
            if (string.IsNullOrWhiteSpace(nroCatastral))
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

            DgvProyectos.Columns[0].Visible = false;
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que quiere borrar el proyecto?",
                                    "Confirmar borrado",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

            DataGridViewRow filaSeleccionada = DgvProyectos.SelectedRows[0];
            string numCatastral = filaSeleccionada.Cells["NroCatastral"].Value?.ToString();


            string idProyecto = oServicio.TraerCodigoProyecto(numCatastral);


            if (resultado == DialogResult.Yes)
            {
                try
                {
                    oServicio.BorrarProyecto(idProyecto);
                    MessageBox.Show("Proyecto borrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al borrar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProyectos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DgvProyectos.SelectedRows[0];
                string numCatastral = filaSeleccionada.Cells["NroCatastral"].Value?.ToString();

                FormDetallesModificar fdm = new FormDetallesModificar(numCatastral);
                fdm.Show();

            }
            else
            {
                MessageBox.Show("Por favor seleccione un proyecto primero", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
