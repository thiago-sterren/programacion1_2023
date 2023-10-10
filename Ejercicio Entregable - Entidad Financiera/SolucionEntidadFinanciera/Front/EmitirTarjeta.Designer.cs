namespace Front
{
    partial class EmitirTarjeta
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(771, 75);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(915, 369);
            button2.Name = "button2";
            button2.Size = new Size(151, 79);
            button2.TabIndex = 3;
            button2.Text = "Emitir tarjeta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 108);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 4;
            label1.Text = "Límite crédito:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 187);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 5;
            label2.Text = "Saldo disponible:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 261);
            label3.Name = "label3";
            label3.Size = new Size(444, 25);
            label3.TabIndex = 6;
            label3.Text = "Seleccione al cliente al que quiera asignarle esta tarjeta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(61, 309);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(716, 379);
            listBox1.TabIndex = 9;
            // 
            // EmitirTarjeta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 769);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EmitirTarjeta";
            Text = "EmitirTarjeta";
            Load += EmitirTarjeta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
    }
}