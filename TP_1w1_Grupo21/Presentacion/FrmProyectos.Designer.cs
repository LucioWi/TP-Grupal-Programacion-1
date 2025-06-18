namespace TP_1w1_Grupo21
{
    partial class FrmProyectos
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 2;
            label1.Text = "Proyectos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(821, 288);
            dataGridView1.TabIndex = 2;
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
            btnSalir.Location = new Point(765, 456);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 33);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 23);
            textBox1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Control;
            btnBuscar.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnBuscar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnBuscar.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ControlText;
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(438, 97);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 33);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 56);
            label2.Name = "label2";
            label2.Size = new Size(502, 15);
            label2.TabIndex = 10;
            label2.Text = "___________________________________________________________________________________________________";
            // 
            // FrmProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 501);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FrmProyectos";
            Text = "FrmProyectos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSalir;
        private TextBox textBox1;
        private Button btnBuscar;
        private Label label2;
    }
}