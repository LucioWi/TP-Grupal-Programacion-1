namespace Tp_Programacion_I
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPpalVer = new System.Windows.Forms.Button();
            this.btnPpalAgregar = new System.Windows.Forms.Button();
            this.btnPpalNosotros = new System.Windows.Forms.Button();
            this.btnPpalSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // btnPpalVer
            // 
            this.btnPpalVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalVer.Location = new System.Drawing.Point(50, 90);
            this.btnPpalVer.Name = "btnPpalVer";
            this.btnPpalVer.Size = new System.Drawing.Size(167, 40);
            this.btnPpalVer.TabIndex = 1;
            this.btnPpalVer.Text = "Ver Proyectos";
            this.btnPpalVer.UseVisualStyleBackColor = true;
            this.btnPpalVer.Click += new System.EventHandler(this.btnPpalVer_Click);
            // 
            // btnPpalAgregar
            // 
            this.btnPpalAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalAgregar.Location = new System.Drawing.Point(50, 149);
            this.btnPpalAgregar.Name = "btnPpalAgregar";
            this.btnPpalAgregar.Size = new System.Drawing.Size(167, 40);
            this.btnPpalAgregar.TabIndex = 2;
            this.btnPpalAgregar.Text = "Agregar Proyectos";
            this.btnPpalAgregar.UseVisualStyleBackColor = true;
            this.btnPpalAgregar.Click += new System.EventHandler(this.btnPpalAgregar_Click);
            // 
            // btnPpalNosotros
            // 
            this.btnPpalNosotros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalNosotros.Location = new System.Drawing.Point(50, 208);
            this.btnPpalNosotros.Name = "btnPpalNosotros";
            this.btnPpalNosotros.Size = new System.Drawing.Size(167, 40);
            this.btnPpalNosotros.TabIndex = 3;
            this.btnPpalNosotros.Text = "Sobre Nosotros";
            this.btnPpalNosotros.UseVisualStyleBackColor = true;
            // 
            // btnPpalSalir
            // 
            this.btnPpalSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalSalir.Location = new System.Drawing.Point(50, 271);
            this.btnPpalSalir.Name = "btnPpalSalir";
            this.btnPpalSalir.Size = new System.Drawing.Size(167, 40);
            this.btnPpalSalir.TabIndex = 4;
            this.btnPpalSalir.Text = "Salir";
            this.btnPpalSalir.UseVisualStyleBackColor = true;
            this.btnPpalSalir.Click += new System.EventHandler(this.btnPpalSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestor de Proectos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPpalSalir);
            this.Controls.Add(this.btnPpalNosotros);
            this.Controls.Add(this.btnPpalAgregar);
            this.Controls.Add(this.btnPpalVer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "Estudio Arquitectura";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnPpalVer;
        private System.Windows.Forms.Button btnPpalAgregar;
        private System.Windows.Forms.Button btnPpalNosotros;
        private System.Windows.Forms.Button btnPpalSalir;
        private System.Windows.Forms.Label label1;
    }
}

