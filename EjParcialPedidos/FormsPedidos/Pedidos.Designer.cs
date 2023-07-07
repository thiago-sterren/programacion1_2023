namespace FormsPedidos
{
    partial class Pedidos
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.btnAgregarPedLoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregarPedOnl = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(512, 131);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(512, 237);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 60);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sucursal\r\n(Completar solo \r\nsi el pedido es local):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(512, 294);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(100, 26);
            this.txtSucursal.TabIndex = 9;
            // 
            // btnAgregarPedLoc
            // 
            this.btnAgregarPedLoc.Location = new System.Drawing.Point(372, 483);
            this.btnAgregarPedLoc.Name = "btnAgregarPedLoc";
            this.btnAgregarPedLoc.Size = new System.Drawing.Size(117, 94);
            this.btnAgregarPedLoc.TabIndex = 10;
            this.btnAgregarPedLoc.Text = "Agregar Pedido Local";
            this.btnAgregarPedLoc.UseVisualStyleBackColor = true;
            this.btnAgregarPedLoc.Click += new System.EventHandler(this.btnAgregarPedLoc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(770, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(985, 124);
            this.listBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 60);
            this.label5.TabIndex = 12;
            this.label5.Text = "Direccion\r\n(Completar solo\r\nsi el pedido es online):";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(512, 383);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 26);
            this.txtDireccion.TabIndex = 13;
            // 
            // btnAgregarPedOnl
            // 
            this.btnAgregarPedOnl.Location = new System.Drawing.Point(529, 483);
            this.btnAgregarPedOnl.Name = "btnAgregarPedOnl";
            this.btnAgregarPedOnl.Size = new System.Drawing.Size(117, 94);
            this.btnAgregarPedOnl.TabIndex = 14;
            this.btnAgregarPedOnl.Text = "Agregar Pedido Online";
            this.btnAgregarPedOnl.UseVisualStyleBackColor = true;
            this.btnAgregarPedOnl.Click += new System.EventHandler(this.btnAgregarPedOnl_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(770, 322);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(985, 124);
            this.listBox2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lista de pedidos locales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lista de pedidos online:";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 724);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnAgregarPedOnl);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAgregarPedLoc);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Button btnAgregarPedLoc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAgregarPedOnl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}