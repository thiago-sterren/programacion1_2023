namespace Front
{
    partial class MenuPrincipal
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
            btnAgregarCliente = new Button();
            btnCrearCuenta = new Button();
            btnEmitirTarjeta = new Button();
            btnMiTarjeta = new Button();
            btnMovDinero = new Button();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(137, 106);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(201, 86);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(137, 209);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(201, 86);
            btnCrearCuenta.TabIndex = 1;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnEmitirTarjeta
            // 
            btnEmitirTarjeta.Location = new Point(137, 312);
            btnEmitirTarjeta.Name = "btnEmitirTarjeta";
            btnEmitirTarjeta.Size = new Size(201, 86);
            btnEmitirTarjeta.TabIndex = 2;
            btnEmitirTarjeta.Text = "Emitir tarjeta";
            btnEmitirTarjeta.UseVisualStyleBackColor = true;
            btnEmitirTarjeta.Click += btnEmitirTarjeta_Click;
            // 
            // btnMiTarjeta
            // 
            btnMiTarjeta.Location = new Point(137, 417);
            btnMiTarjeta.Name = "btnMiTarjeta";
            btnMiTarjeta.Size = new Size(201, 94);
            btnMiTarjeta.TabIndex = 3;
            btnMiTarjeta.Text = "Mi tarjeta";
            btnMiTarjeta.UseVisualStyleBackColor = true;
            btnMiTarjeta.Click += btnMiTarjeta_Click;
            // 
            // btnMovDinero
            // 
            btnMovDinero.Location = new Point(818, 255);
            btnMovDinero.Name = "btnMovDinero";
            btnMovDinero.Size = new Size(201, 86);
            btnMovDinero.TabIndex = 4;
            btnMovDinero.Text = "Movimientos financieros";
            btnMovDinero.UseVisualStyleBackColor = true;
            btnMovDinero.Click += btnMovDinero_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 687);
            Controls.Add(btnMovDinero);
            Controls.Add(btnMiTarjeta);
            Controls.Add(btnEmitirTarjeta);
            Controls.Add(btnCrearCuenta);
            Controls.Add(btnAgregarCliente);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarCliente;
        private Button btnCrearCuenta;
        private Button btnEmitirTarjeta;
        private Button btnMiTarjeta;
        private Button btnMovDinero;
    }
}