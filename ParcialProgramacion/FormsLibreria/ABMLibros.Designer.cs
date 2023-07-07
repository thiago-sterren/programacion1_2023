namespace FormsLibreria
{
    partial class ABMLibros
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNroPags = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.btnAltaLibroFisico = new System.Windows.Forms.Button();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.btnBajaLibro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAltaLibroDigital = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear nuevo libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(203, 75);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 26);
            this.txtISBN.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(203, 119);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 26);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(203, 166);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 26);
            this.txtAutor.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(203, 212);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 60);
            this.label6.TabIndex = 9;
            this.label6.Text = "Numero de paginas\r\n(completar para agregar\r\nun libro fisico):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 60);
            this.label7.TabIndex = 10;
            this.label7.Text = "Peso en gramos\r\n(completar para agregar\r\nun libro fisico):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 60);
            this.label8.TabIndex = 11;
            this.label8.Text = "Formato\r\n(completar para agregar\r\nun libro digital):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 60);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tamaño en MB\r\n(completar para agregar\r\nun libro digital):";
            // 
            // txtNroPags
            // 
            this.txtNroPags.Location = new System.Drawing.Point(203, 281);
            this.txtNroPags.Name = "txtNroPags";
            this.txtNroPags.Size = new System.Drawing.Size(100, 26);
            this.txtNroPags.TabIndex = 13;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(203, 368);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 14;
            // 
            // txtFormato
            // 
            this.txtFormato.Location = new System.Drawing.Point(203, 458);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(100, 26);
            this.txtFormato.TabIndex = 15;
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(203, 547);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 26);
            this.txtTamanio.TabIndex = 16;
            // 
            // btnAltaLibroFisico
            // 
            this.btnAltaLibroFisico.Location = new System.Drawing.Point(73, 612);
            this.btnAltaLibroFisico.Name = "btnAltaLibroFisico";
            this.btnAltaLibroFisico.Size = new System.Drawing.Size(146, 63);
            this.btnAltaLibroFisico.TabIndex = 17;
            this.btnAltaLibroFisico.Text = "Crear libro fisico";
            this.btnAltaLibroFisico.UseVisualStyleBackColor = true;
            this.btnAltaLibroFisico.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.ItemHeight = 20;
            this.listBoxLibros.Location = new System.Drawing.Point(361, 36);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(1212, 364);
            this.listBoxLibros.TabIndex = 18;
            // 
            // btnBajaLibro
            // 
            this.btnBajaLibro.Location = new System.Drawing.Point(692, 612);
            this.btnBajaLibro.Name = "btnBajaLibro";
            this.btnBajaLibro.Size = new System.Drawing.Size(146, 63);
            this.btnBajaLibro.TabIndex = 19;
            this.btnBajaLibro.Text = "Dar de baja";
            this.btnBajaLibro.UseVisualStyleBackColor = true;
            this.btnBajaLibro.Click += new System.EventHandler(this.btnBajaLibro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(425, 40);
            this.label10.TabIndex = 20;
            this.label10.Text = "Para dar de baja un libro, seleccione previamente\r\nel libro deseado en la lista d" +
    "e arriba y luego de a este botón";
            // 
            // btnAltaLibroDigital
            // 
            this.btnAltaLibroDigital.Location = new System.Drawing.Point(259, 612);
            this.btnAltaLibroDigital.Name = "btnAltaLibroDigital";
            this.btnAltaLibroDigital.Size = new System.Drawing.Size(146, 63);
            this.btnAltaLibroDigital.TabIndex = 22;
            this.btnAltaLibroDigital.Text = "Crear libro digital";
            this.btnAltaLibroDigital.UseVisualStyleBackColor = true;
            this.btnAltaLibroDigital.Click += new System.EventHandler(this.btnAltaLibroDigital_Click);
            // 
            // ABMLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 796);
            this.Controls.Add(this.btnAltaLibroDigital);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBajaLibro);
            this.Controls.Add(this.listBoxLibros);
            this.Controls.Add(this.btnAltaLibroFisico);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNroPags);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABMLibros";
            this.Text = "ABMLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNroPags;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Button btnAltaLibroFisico;
        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.Button btnBajaLibro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAltaLibroDigital;
    }
}