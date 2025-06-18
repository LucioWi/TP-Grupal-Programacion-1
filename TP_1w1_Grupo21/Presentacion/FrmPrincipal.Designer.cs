
namespace TP_1w1_Grupo21
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            proyectosToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            nosotrosToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnVer = new Button();
            btnAgregar = new Button();
            btnNosotros = new Button();
            btnSalir = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RoyalBlue;
            menuStrip1.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, consultasToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.ForeColor = SystemColors.Control;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(97, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proyectosToolStripMenuItem });
            soporteToolStripMenuItem.ForeColor = SystemColors.Control;
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(61, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // proyectosToolStripMenuItem
            // 
            proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            proyectosToolStripMenuItem.Size = new Size(126, 22);
            proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.ForeColor = SystemColors.Control;
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(70, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nosotrosToolStripMenuItem });
            acercaDeToolStripMenuItem.ForeColor = SystemColors.Control;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // nosotrosToolStripMenuItem
            // 
            nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            nosotrosToolStripMenuItem.Size = new Size(122, 22);
            nosotrosToolStripMenuItem.Text = "Nosotros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(494, 299);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 3;
            label1.Text = "Gestor de Proyectos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(507, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.Control;
            btnVer.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnVer.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnVer.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVer.ForeColor = SystemColors.ControlText;
            btnVer.ImageAlign = ContentAlignment.MiddleRight;
            btnVer.Location = new Point(30, 71);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(240, 33);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver proyectos";
            btnVer.TextAlign = ContentAlignment.MiddleLeft;
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += this.btnVer_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnAgregar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnAgregar.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ControlText;
            btnAgregar.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregar.Location = new Point(30, 110);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(240, 33);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar proyectos";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += this.btnAgregar_Click;
            // 
            // btnNosotros
            // 
            btnNosotros.BackColor = SystemColors.Control;
            btnNosotros.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnNosotros.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnNosotros.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnNosotros.FlatStyle = FlatStyle.Flat;
            btnNosotros.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNosotros.ForeColor = SystemColors.ControlText;
            btnNosotros.ImageAlign = ContentAlignment.MiddleRight;
            btnNosotros.Location = new Point(30, 149);
            btnNosotros.Name = "btnNosotros";
            btnNosotros.Size = new Size(240, 33);
            btnNosotros.TabIndex = 3;
            btnNosotros.Text = "Sobre nosotros";
            btnNosotros.TextAlign = ContentAlignment.MiddleLeft;
            btnNosotros.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Control;
            btnSalir.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnSalir.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnSalir.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlText;
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(30, 188);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(240, 33);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnNosotros);
            Controls.Add(btnAgregar);
            Controls.Add(btnVer);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem proyectosToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem nosotrosToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnVer;
        private Button btnAgregar;
        private Button btnNosotros;
        private Button btnSalir;
    }
}