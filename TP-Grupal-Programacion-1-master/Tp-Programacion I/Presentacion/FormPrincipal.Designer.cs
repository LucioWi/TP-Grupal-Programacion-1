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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPpalVer = new System.Windows.Forms.Button();
            this.btnPpalAgregar = new System.Windows.Forms.Button();
            this.btnPpalNosotros = new System.Windows.Forms.Button();
            this.btnPpalSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosToolStripMenuItem});
            this.soporteToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soporteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.proyectosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nosotrosToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            this.nosotrosToolStripMenuItem.Click += new System.EventHandler(this.nosotrosToolStripMenuItem_Click);
            // 
            // btnPpalVer
            // 
            this.btnPpalVer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalVer.Location = new System.Drawing.Point(23, 68);
            this.btnPpalVer.Name = "btnPpalVer";
            this.btnPpalVer.Size = new System.Drawing.Size(263, 32);
            this.btnPpalVer.TabIndex = 1;
            this.btnPpalVer.Text = "Ver Proyectos";
            this.btnPpalVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPpalVer.UseVisualStyleBackColor = true;
            this.btnPpalVer.Click += new System.EventHandler(this.btnPpalVer_Click);
            // 
            // btnPpalAgregar
            // 
            this.btnPpalAgregar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalAgregar.Location = new System.Drawing.Point(23, 106);
            this.btnPpalAgregar.Name = "btnPpalAgregar";
            this.btnPpalAgregar.Size = new System.Drawing.Size(263, 32);
            this.btnPpalAgregar.TabIndex = 2;
            this.btnPpalAgregar.Text = "Agregar Proyectos";
            this.btnPpalAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPpalAgregar.UseVisualStyleBackColor = true;
            this.btnPpalAgregar.Click += new System.EventHandler(this.btnPpalAgregar_Click);
            // 
            // btnPpalNosotros
            // 
            this.btnPpalNosotros.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalNosotros.Location = new System.Drawing.Point(23, 144);
            this.btnPpalNosotros.Name = "btnPpalNosotros";
            this.btnPpalNosotros.Size = new System.Drawing.Size(263, 32);
            this.btnPpalNosotros.TabIndex = 3;
            this.btnPpalNosotros.Text = "Sobre Nosotros";
            this.btnPpalNosotros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPpalNosotros.UseVisualStyleBackColor = true;
            this.btnPpalNosotros.Click += new System.EventHandler(this.btnPpalNosotros_Click);
            // 
            // btnPpalSalir
            // 
            this.btnPpalSalir.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpalSalir.Location = new System.Drawing.Point(23, 182);
            this.btnPpalSalir.Name = "btnPpalSalir";
            this.btnPpalSalir.Size = new System.Drawing.Size(263, 32);
            this.btnPpalSalir.TabIndex = 4;
            this.btnPpalSalir.Text = "Salir";
            this.btnPpalSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPpalSalir.UseVisualStyleBackColor = true;
            this.btnPpalSalir.Click += new System.EventHandler(this.btnPpalSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestor de Proyectos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPpalSalir);
            this.Controls.Add(this.btnPpalNosotros);
            this.Controls.Add(this.btnPpalAgregar);
            this.Controls.Add(this.btnPpalVer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Estudio Arquitectura";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

