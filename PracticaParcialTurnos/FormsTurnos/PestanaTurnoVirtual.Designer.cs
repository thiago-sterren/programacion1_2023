namespace FormsTurnos
{
    partial class PestanaTurnoVirtual
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtDuracionTV = new System.Windows.Forms.TextBox();
            this.txtPlataformaTV = new System.Windows.Forms.TextBox();
            this.btnReservarTV = new System.Windows.Forms.Button();
            this.btnVolverTV = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duracion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plataforma:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // txtDuracionTV
            // 
            this.txtDuracionTV.Location = new System.Drawing.Point(203, 131);
            this.txtDuracionTV.Name = "txtDuracionTV";
            this.txtDuracionTV.Size = new System.Drawing.Size(100, 26);
            this.txtDuracionTV.TabIndex = 4;
            // 
            // txtPlataformaTV
            // 
            this.txtPlataformaTV.Location = new System.Drawing.Point(203, 184);
            this.txtPlataformaTV.Name = "txtPlataformaTV";
            this.txtPlataformaTV.Size = new System.Drawing.Size(100, 26);
            this.txtPlataformaTV.TabIndex = 5;
            // 
            // btnReservarTV
            // 
            this.btnReservarTV.Location = new System.Drawing.Point(288, 263);
            this.btnReservarTV.Name = "btnReservarTV";
            this.btnReservarTV.Size = new System.Drawing.Size(115, 45);
            this.btnReservarTV.TabIndex = 6;
            this.btnReservarTV.Text = "Reservar";
            this.btnReservarTV.UseVisualStyleBackColor = true;
            this.btnReservarTV.Click += new System.EventHandler(this.btnReservarTV_Click);
            // 
            // btnVolverTV
            // 
            this.btnVolverTV.Location = new System.Drawing.Point(669, 451);
            this.btnVolverTV.Name = "btnVolverTV";
            this.btnVolverTV.Size = new System.Drawing.Size(115, 45);
            this.btnVolverTV.TabIndex = 7;
            this.btnVolverTV.Text = "Volver";
            this.btnVolverTV.UseVisualStyleBackColor = true;
            this.btnVolverTV.Click += new System.EventHandler(this.btnVolverTV_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(482, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(785, 344);
            this.listBox1.TabIndex = 8;
            // 
            // PestanaTurnoVirtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 701);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVolverTV);
            this.Controls.Add(this.btnReservarTV);
            this.Controls.Add(this.txtPlataformaTV);
            this.Controls.Add(this.txtDuracionTV);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PestanaTurnoVirtual";
            this.Text = "PestanaTurnoVirtual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtDuracionTV;
        private System.Windows.Forms.TextBox txtPlataformaTV;
        private System.Windows.Forms.Button btnReservarTV;
        private System.Windows.Forms.Button btnVolverTV;
        private System.Windows.Forms.ListBox listBox1;
    }
}