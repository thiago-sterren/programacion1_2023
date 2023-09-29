namespace Front
{
    partial class MovimientosFinancieros
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
            btnDepositar = new Button();
            btnExtraer = new Button();
            btnTransferencia = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(303, 340);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(157, 63);
            btnDepositar.TabIndex = 0;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnExtraer
            // 
            btnExtraer.Location = new Point(487, 340);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(157, 63);
            btnExtraer.TabIndex = 1;
            btnExtraer.Text = "Extraer";
            btnExtraer.UseVisualStyleBackColor = true;
            btnExtraer.Click += btnExtraer_Click;
            // 
            // btnTransferencia
            // 
            btnTransferencia.Location = new Point(894, 423);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(157, 63);
            btnTransferencia.TabIndex = 2;
            btnTransferencia.Text = "Transferir a otra cuenta";
            btnTransferencia.UseVisualStyleBackColor = true;
            btnTransferencia.Click += btnTransferencia_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 146);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 5;
            label1.Text = "Número de cuenta bancaria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 201);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 6;
            label2.Text = "Monto:";
            // 
            // button1
            // 
            button1.Location = new Point(986, 53);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MovimientosFinancieros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 609);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnTransferencia);
            Controls.Add(btnExtraer);
            Controls.Add(btnDepositar);
            Name = "MovimientosFinancieros";
            Text = "MovimientosFinancieros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDepositar;
        private Button btnExtraer;
        private Button btnTransferencia;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}