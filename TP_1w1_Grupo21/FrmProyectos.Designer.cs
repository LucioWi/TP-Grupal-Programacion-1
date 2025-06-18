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
            button4 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
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
            dataGridView1.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.FlatAppearance.BorderColor = SystemColors.ControlText;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(765, 456);
            button4.Name = "button4";
            button4.Size = new Size(81, 33);
            button4.TabIndex = 7;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderColor = SystemColors.ControlText;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(409, 97);
            button1.Name = "button1";
            button1.Size = new Size(84, 33);
            button1.TabIndex = 9;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 501);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button4);
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
        private Button button4;
        private TextBox textBox1;
        private Button button1;
    }
}