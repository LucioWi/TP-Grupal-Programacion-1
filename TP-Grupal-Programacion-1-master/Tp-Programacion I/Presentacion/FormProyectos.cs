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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tp_Programacion_I
{
    public partial class FormProyectos : Form
    {
        AccesoDatos oBD;
        String idProyecto;
        public FormProyectos()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtBuscar.Text))
            {
                MessageBox.Show("Codigo no puede estar vacio");
                return;
            }
            else {
                idProyecto = txtBuscar.Text;
            }
                
            string consultaSQL = $@"
                                SELECT p.id_proyecto, tp.tipo_proyecto, p.nro_catastral, p.fecha_inicio, 
                                        p.fecha_final , c.nombre, ep.estado
                                FROM proyectos p
                                JOIN tipo_proyectos tp ON p.id_tipo_proyecto = tp.id_tipo_proyecto
                                JOIN clientes c ON p.id_cliente = c.id_cliente
                                JOIN estados_proyectos ep ON p.id_estado_proyecto = ep.id_estado_proyecto
                                WHERE p.id_proyecto = {idProyecto}";

            DataTable tabla = oBD.ConsultarBD(consultaSQL);

            dgvProyectos.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvProyectos.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6]);
            }
        } 
        private void btnProySalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
