namespace FormsTurnos
{
    partial class PestanaTurnoPresencial
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
            this.btnReservaTP = new System.Windows.Forms.Button();
            this.btnVolverTP = new System.Windows.Forms.Button();
            this.txtDuracionTP = new System.Windows.Forms.TextBox();
            this.txtLugarTP = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duracion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugar:";
            // 
            // btnReservaTP
            // 
            this.btnReservaTP.Location = new System.Drawing.Point(261, 211);
            this.btnReservaTP.Name = "btnReservaTP";
            this.btnReservaTP.Size = new System.Drawing.Size(117, 46);
            this.btnReservaTP.TabIndex = 3;
            this.btnReservaTP.Text = "Reservar";
            this.btnReservaTP.UseVisualStyleBackColor = true;
            this.btnReservaTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolverTP
            // 
            this.btnVolverTP.Location = new System.Drawing.Point(677, 573);
            this.btnVolverTP.Name = "btnVolverTP";
            this.btnVolverTP.Size = new System.Drawing.Size(117, 46);
            this.btnVolverTP.TabIndex = 4;
            this.btnVolverTP.Text = "Volver";
            this.btnVolverTP.UseVisualStyleBackColor = true;
            this.btnVolverTP.Click += new System.EventHandler(this.btnVolverTP_Click);
            // 
            // txtDuracionTP
            // 
            this.txtDuracionTP.Location = new System.Drawing.Point(174, 89);
            this.txtDuracionTP.Name = "txtDuracionTP";
            this.txtDuracionTP.Size = new System.Drawing.Size(100, 26);
            this.txtDuracionTP.TabIndex = 6;
            // 
            // txtLugarTP
            // 
            this.txtLugarTP.Location = new System.Drawing.Point(174, 133);
            this.txtLugarTP.Name = "txtLugarTP";
            this.txtLugarTP.Size = new System.Drawing.Size(100, 26);
            this.txtLugarTP.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(423, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(810, 384);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PestanaTurnoPresencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 684);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtLugarTP);
            this.Controls.Add(this.txtDuracionTP);
            this.Controls.Add(this.btnVolverTP);
            this.Controls.Add(this.btnReservaTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PestanaTurnoPresencial";
            this.Text = "PestanaTurnoPresencial";
            this.Load += new System.EventHandler(this.PestanaTurnoPresencial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReservaTP;
        private System.Windows.Forms.Button btnVolverTP;
        private System.Windows.Forms.TextBox txtDuracionTP;
        private System.Windows.Forms.TextBox txtLugarTP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
    }
}