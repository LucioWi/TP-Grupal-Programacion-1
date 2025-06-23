namespace Tp_Programacion_I
{
    partial class FormProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.DgvProyectos = new System.Windows.Forms.DataGridView();
            this.btnProySalir = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCatastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyectos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(575, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "_______________________________________________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(555, 121);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(25, 126);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(492, 26);
            this.txtBuscar.TabIndex = 0;
            // 
            // DgvProyectos
            // 
            this.DgvProyectos.AllowUserToAddRows = false;
            this.DgvProyectos.AllowUserToDeleteRows = false;
            this.DgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.TipoProyecto,
            this.NroCatastral,
            this.FechaInicio,
            this.FechaFinal,
            this.Cliente,
            this.Estado});
            this.DgvProyectos.Location = new System.Drawing.Point(13, 191);
            this.DgvProyectos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvProyectos.Name = "DgvProyectos";
            this.DgvProyectos.RowHeadersWidth = 51;
            this.DgvProyectos.Size = new System.Drawing.Size(1069, 342);
            this.DgvProyectos.TabIndex = 2;
            this.DgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProyectos_CellContentClick);
            // 
            // btnProySalir
            // 
            this.btnProySalir.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProySalir.Location = new System.Drawing.Point(976, 591);
            this.btnProySalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProySalir.Name = "btnProySalir";
            this.btnProySalir.Size = new System.Drawing.Size(119, 38);
            this.btnProySalir.TabIndex = 3;
            this.btnProySalir.Text = "Salir";
            this.btnProySalir.UseVisualStyleBackColor = true;
            this.btnProySalir.Click += new System.EventHandler(this.btnProySalir_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 90;
            // 
            // TipoProyecto
            // 
            this.TipoProyecto.HeaderText = "Tipo de Proyecto";
            this.TipoProyecto.MinimumWidth = 6;
            this.TipoProyecto.Name = "TipoProyecto";
            this.TipoProyecto.Width = 125;
            // 
            // NroCatastral
            // 
            this.NroCatastral.FillWeight = 90F;
            this.NroCatastral.HeaderText = "Número catastral";
            this.NroCatastral.MinimumWidth = 6;
            this.NroCatastral.Name = "NroCatastral";
            this.NroCatastral.Width = 90;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 125;
            // 
            // FechaFinal
            // 
            this.FechaFinal.HeaderText = "Fecha Final";
            this.FechaFinal.MinimumWidth = 6;
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.FillWeight = 120F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 140;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // FormProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 644);
            this.Controls.Add(this.btnProySalir);
            this.Controls.Add(this.DgvProyectos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProyectos";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.FormProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView DgvProyectos;
        private System.Windows.Forms.Button btnProySalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCatastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}