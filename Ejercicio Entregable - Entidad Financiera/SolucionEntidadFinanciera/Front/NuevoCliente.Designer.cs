namespace Front
{
    partial class NuevoCliente
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCrear = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(901, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(408, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(408, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 109);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 158);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 205);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 8;
            label3.Text = "DNI:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(408, 354);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(150, 51);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(408, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 249);
            label4.Name = "label4";
            label4.Size = new Size(276, 25);
            label4.TabIndex = 11;
            label4.Text = "¿Qué tipo de cuenta desea tener?";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(408, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 288);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 15;
            label7.Text = "Saldo:";
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 567);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(btnCrear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "NuevoCliente";
            Text = "NuevoCliente";
            Load += NuevoCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCrear;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox4;
        private Label label7;
    }
}