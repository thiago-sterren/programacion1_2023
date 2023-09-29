namespace Front
{
    partial class MiTarjeta
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
            btnPausar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btnPagar = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            btnDeuda = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnPausar
            // 
            btnPausar.Location = new Point(724, 460);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(172, 57);
            btnPausar.TabIndex = 0;
            btnPausar.Text = "Pausar tarjeta";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(451, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 130);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 2;
            label1.Text = "Número tarjeta:";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(464, 333);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(172, 57);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar deuda";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(451, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 31);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 201);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 5;
            label2.Text = "Monto a pagar:";
            // 
            // btnDeuda
            // 
            btnDeuda.Location = new Point(684, 196);
            btnDeuda.Name = "btnDeuda";
            btnDeuda.Size = new Size(112, 34);
            btnDeuda.TabIndex = 6;
            btnDeuda.Text = "Mi deuda";
            btnDeuda.UseVisualStyleBackColor = true;
            btnDeuda.Click += btnDeuda_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1038, 48);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MiTarjeta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 675);
            Controls.Add(button1);
            Controls.Add(btnDeuda);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(btnPagar);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnPausar);
            Name = "MiTarjeta";
            Text = "MiTarjeta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPausar;
        private TextBox textBox1;
        private Label label1;
        private Button btnPagar;
        private TextBox textBox2;
        private Label label2;
        private Button btnDeuda;
        private Button button1;
    }
}