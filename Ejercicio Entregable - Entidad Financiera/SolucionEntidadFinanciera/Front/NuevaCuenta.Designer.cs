namespace Front
{
    partial class NuevaCuenta
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
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1198, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 136);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 10;
            label2.Text = "Tipo de cuenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 80);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 9;
            label1.Text = "Saldo:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(168, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(964, 424);
            button2.Name = "button2";
            button2.Size = new Size(179, 92);
            button2.TabIndex = 15;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 196);
            label3.Name = "label3";
            label3.Size = new Size(447, 25);
            label3.TabIndex = 16;
            label3.Text = "Seleccione el cliente al que quiera asignarle esta cuenta:";
            label3.Click += label3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(29, 241);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(749, 429);
            listBox1.TabIndex = 17;
            // 
            // NuevaCuenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 688);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "NuevaCuenta";
            Text = "NuevaCuenta";
            Load += NuevaCuenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label3;
        private ListBox listBox1;
    }
}