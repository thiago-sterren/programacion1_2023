namespace FormsElectronica
{
    partial class MenuPrincipal
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
            this.btnTele = new System.Windows.Forms.Button();
            this.btnSmart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTele
            // 
            this.btnTele.Location = new System.Drawing.Point(114, 178);
            this.btnTele.Name = "btnTele";
            this.btnTele.Size = new System.Drawing.Size(124, 71);
            this.btnTele.TabIndex = 0;
            this.btnTele.Text = "Televisores";
            this.btnTele.UseVisualStyleBackColor = true;
            this.btnTele.Click += new System.EventHandler(this.btnTele_Click);
            // 
            // btnSmart
            // 
            this.btnSmart.Location = new System.Drawing.Point(468, 178);
            this.btnSmart.Name = "btnSmart";
            this.btnSmart.Size = new System.Drawing.Size(124, 71);
            this.btnSmart.TabIndex = 1;
            this.btnSmart.Text = "Smartphones";
            this.btnSmart.UseVisualStyleBackColor = true;
            this.btnSmart.Click += new System.EventHandler(this.btnSmart_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmart);
            this.Controls.Add(this.btnTele);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTele;
        private System.Windows.Forms.Button btnSmart;
    }
}

