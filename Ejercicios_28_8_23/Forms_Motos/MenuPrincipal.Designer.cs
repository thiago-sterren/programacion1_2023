namespace Forms_Motos
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
            this.btnDep = new System.Windows.Forms.Button();
            this.btnUti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(76, 148);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(123, 62);
            this.btnDep.TabIndex = 0;
            this.btnDep.Text = "Motos Deportivas";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnUti
            // 
            this.btnUti.Location = new System.Drawing.Point(327, 148);
            this.btnUti.Name = "btnUti";
            this.btnUti.Size = new System.Drawing.Size(123, 62);
            this.btnUti.TabIndex = 1;
            this.btnUti.Text = "Motos Utilitarias";
            this.btnUti.UseVisualStyleBackColor = true;
            this.btnUti.Click += new System.EventHandler(this.btnUti_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUti);
            this.Controls.Add(this.btnDep);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.Button btnUti;
    }
}

