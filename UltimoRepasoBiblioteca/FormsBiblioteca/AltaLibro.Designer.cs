namespace FormsBiblioteca
{
    partial class AltaLibro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAnioPub = new System.Windows.Forms.TextBox();
            this.txtNroPag = new System.Windows.Forms.TextBox();
            this.txtTamAr = new System.Windows.Forms.TextBox();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.btnCrearLibro = new System.Windows.Forms.Button();
            this.btnVolverLibro = new System.Windows.Forms.Button();
            this.raBtnFisico = new System.Windows.Forms.RadioButton();
            this.raBtnDigital = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Anio publicacion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 60);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero paginas\r\n(rellenar solo\r\npara libro fisico)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 60);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tamanio archivo\r\n(rellenar solo\r\npara libro digital)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 60);
            this.label11.TabIndex = 10;
            this.label11.Text = "Formato\r\n(rellenar solo\r\npara libro digital)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(206, 113);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 26);
            this.txtTitulo.TabIndex = 11;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(206, 170);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 26);
            this.txtAutor.TabIndex = 12;
            // 
            // txtAnioPub
            // 
            this.txtAnioPub.Location = new System.Drawing.Point(206, 225);
            this.txtAnioPub.Name = "txtAnioPub";
            this.txtAnioPub.Size = new System.Drawing.Size(100, 26);
            this.txtAnioPub.TabIndex = 13;
            // 
            // txtNroPag
            // 
            this.txtNroPag.Location = new System.Drawing.Point(206, 389);
            this.txtNroPag.Name = "txtNroPag";
            this.txtNroPag.Size = new System.Drawing.Size(100, 26);
            this.txtNroPag.TabIndex = 14;
            // 
            // txtTamAr
            // 
            this.txtTamAr.Location = new System.Drawing.Point(206, 481);
            this.txtTamAr.Name = "txtTamAr";
            this.txtTamAr.Size = new System.Drawing.Size(100, 26);
            this.txtTamAr.TabIndex = 18;
            // 
            // txtFor
            // 
            this.txtFor.Location = new System.Drawing.Point(206, 574);
            this.txtFor.Name = "txtFor";
            this.txtFor.Size = new System.Drawing.Size(100, 26);
            this.txtFor.TabIndex = 19;
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.ItemHeight = 20;
            this.listBoxLibros.Location = new System.Drawing.Point(492, 55);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(774, 424);
            this.listBoxLibros.TabIndex = 20;
            // 
            // btnCrearLibro
            // 
            this.btnCrearLibro.Location = new System.Drawing.Point(357, 574);
            this.btnCrearLibro.Name = "btnCrearLibro";
            this.btnCrearLibro.Size = new System.Drawing.Size(113, 64);
            this.btnCrearLibro.TabIndex = 21;
            this.btnCrearLibro.Text = "Crear libro";
            this.btnCrearLibro.UseVisualStyleBackColor = true;
            this.btnCrearLibro.Click += new System.EventHandler(this.btnCrearLibro_Click);
            // 
            // btnVolverLibro
            // 
            this.btnVolverLibro.Location = new System.Drawing.Point(817, 537);
            this.btnVolverLibro.Name = "btnVolverLibro";
            this.btnVolverLibro.Size = new System.Drawing.Size(150, 86);
            this.btnVolverLibro.TabIndex = 23;
            this.btnVolverLibro.Text = "Volver al menu principal";
            this.btnVolverLibro.UseVisualStyleBackColor = true;
            this.btnVolverLibro.Click += new System.EventHandler(this.btnVolverLibro_Click);
            // 
            // raBtnFisico
            // 
            this.raBtnFisico.AutoSize = true;
            this.raBtnFisico.Location = new System.Drawing.Point(126, 278);
            this.raBtnFisico.Name = "raBtnFisico";
            this.raBtnFisico.Size = new System.Drawing.Size(75, 24);
            this.raBtnFisico.TabIndex = 24;
            this.raBtnFisico.TabStop = true;
            this.raBtnFisico.Text = "Fisico";
            this.raBtnFisico.UseVisualStyleBackColor = true;
            // 
            // raBtnDigital
            // 
            this.raBtnDigital.AutoSize = true;
            this.raBtnDigital.Location = new System.Drawing.Point(126, 318);
            this.raBtnDigital.Name = "raBtnDigital";
            this.raBtnDigital.Size = new System.Drawing.Size(78, 24);
            this.raBtnDigital.TabIndex = 25;
            this.raBtnDigital.TabStop = true;
            this.raBtnDigital.Text = "Digital";
            this.raBtnDigital.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 40);
            this.label2.TabIndex = 26;
            this.label2.Text = "(Por favor seleccione\r\nsi o si uno de los dos botones)";
            // 
            // AltaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.raBtnDigital);
            this.Controls.Add(this.raBtnFisico);
            this.Controls.Add(this.btnVolverLibro);
            this.Controls.Add(this.btnCrearLibro);
            this.Controls.Add(this.listBoxLibros);
            this.Controls.Add(this.txtFor);
            this.Controls.Add(this.txtTamAr);
            this.Controls.Add(this.txtNroPag);
            this.Controls.Add(this.txtAnioPub);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AltaLibro";
            this.Text = "AltaLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAnioPub;
        private System.Windows.Forms.TextBox txtNroPag;
        private System.Windows.Forms.TextBox txtTamAr;
        private System.Windows.Forms.TextBox txtFor;
        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.Button btnCrearLibro;
        private System.Windows.Forms.Button btnVolverLibro;
        private System.Windows.Forms.RadioButton raBtnFisico;
        private System.Windows.Forms.RadioButton raBtnDigital;
        private System.Windows.Forms.Label label2;
    }
}