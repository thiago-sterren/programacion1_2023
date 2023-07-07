using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTituloLD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutorLD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnioPubLD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTamArch = new System.Windows.Forms.TextBox();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCrearLD = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTituloLF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAutorLF = new System.Windows.Forms.TextBox();
            this.txtAnioPubLF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumPags = new System.Windows.Forms.TextBox();
            this.btnCrearLF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTituloLD
            // 
            this.txtTituloLD.Location = new System.Drawing.Point(112, 56);
            this.txtTituloLD.Name = "txtTituloLD";
            this.txtTituloLD.Size = new System.Drawing.Size(100, 26);
            this.txtTituloLD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear nuevo libro digital:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Autor:";
            // 
            // txtAutorLD
            // 
            this.txtAutorLD.Location = new System.Drawing.Point(307, 58);
            this.txtAutorLD.Name = "txtAutorLD";
            this.txtAutorLD.Size = new System.Drawing.Size(100, 26);
            this.txtAutorLD.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Anio publicacion:";
            // 
            // txtAnioPubLD
            // 
            this.txtAnioPubLD.Location = new System.Drawing.Point(565, 59);
            this.txtAnioPubLD.Name = "txtAnioPubLD";
            this.txtAnioPubLD.Size = new System.Drawing.Size(100, 26);
            this.txtAnioPubLD.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 14;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTamArch
            // 
            this.txtTamArch.Location = new System.Drawing.Point(843, 61);
            this.txtTamArch.Name = "txtTamArch";
            this.txtTamArch.Size = new System.Drawing.Size(100, 26);
            this.txtTamArch.TabIndex = 15;
            this.txtTamArch.TextChanged += new System.EventHandler(this.txtOpcLibro1_TextChanged);
            // 
            // txtFormato
            // 
            this.txtFormato.Location = new System.Drawing.Point(1054, 62);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(100, 26);
            this.txtFormato.TabIndex = 16;
            this.txtFormato.TextChanged += new System.EventHandler(this.txtOpLibro2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(975, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Formato:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnCrearLD
            // 
            this.btnCrearLD.Location = new System.Drawing.Point(1172, 39);
            this.btnCrearLD.Name = "btnCrearLD";
            this.btnCrearLD.Size = new System.Drawing.Size(146, 70);
            this.btnCrearLD.TabIndex = 27;
            this.btnCrearLD.Text = "Crear libro digital";
            this.btnCrearLD.UseVisualStyleBackColor = true;
            this.btnCrearLD.Click += new System.EventHandler(this.btnCrearLibro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1252, 313);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 51);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tamanio archivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Crear nuevo libro fisico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Titulo:";
            // 
            // txtTituloLF
            // 
            this.txtTituloLF.Location = new System.Drawing.Point(112, 143);
            this.txtTituloLF.Name = "txtTituloLF";
            this.txtTituloLF.Size = new System.Drawing.Size(100, 26);
            this.txtTituloLF.TabIndex = 32;
            this.txtTituloLF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Autor:";
            // 
            // txtAutorLF
            // 
            this.txtAutorLF.Location = new System.Drawing.Point(307, 143);
            this.txtAutorLF.Name = "txtAutorLF";
            this.txtAutorLF.Size = new System.Drawing.Size(100, 26);
            this.txtAutorLF.TabIndex = 34;
            // 
            // txtAnioPubLF
            // 
            this.txtAnioPubLF.Location = new System.Drawing.Point(565, 143);
            this.txtAnioPubLF.Name = "txtAnioPubLF";
            this.txtAnioPubLF.Size = new System.Drawing.Size(100, 26);
            this.txtAnioPubLF.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Anio publicacion:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(701, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Numero de paginas:";
            // 
            // txtNumPags
            // 
            this.txtNumPags.Location = new System.Drawing.Point(858, 146);
            this.txtNumPags.Name = "txtNumPags";
            this.txtNumPags.Size = new System.Drawing.Size(100, 26);
            this.txtNumPags.TabIndex = 38;
            // 
            // btnCrearLF
            // 
            this.btnCrearLF.Location = new System.Drawing.Point(979, 122);
            this.btnCrearLF.Name = "btnCrearLF";
            this.btnCrearLF.Size = new System.Drawing.Size(160, 74);
            this.btnCrearLF.TabIndex = 39;
            this.btnCrearLF.Text = "Crear libro fisico";
            this.btnCrearLF.UseVisualStyleBackColor = true;
            this.btnCrearLF.Click += new System.EventHandler(this.btnCrearLF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 617);
            this.Controls.Add(this.btnCrearLF);
            this.Controls.Add(this.txtNumPags);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAnioPubLF);
            this.Controls.Add(this.txtAutorLF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTituloLF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearLD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.txtTamArch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAnioPubLD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAutorLD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloLD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout(); 

        }

        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTituloLD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutorLD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnioPubLD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTamArch;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCrearLD;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTituloLF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAutorLF;
        private System.Windows.Forms.TextBox txtAnioPubLF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumPags;
        private System.Windows.Forms.Button btnCrearLF;
    }
}

