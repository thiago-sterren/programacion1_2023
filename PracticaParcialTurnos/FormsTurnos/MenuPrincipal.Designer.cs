namespace FormsTurnos
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
            this.btnTurnoP = new System.Windows.Forms.Button();
            this.btnTurnoV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTurnoP
            // 
            this.btnTurnoP.Location = new System.Drawing.Point(153, 117);
            this.btnTurnoP.Name = "btnTurnoP";
            this.btnTurnoP.Size = new System.Drawing.Size(119, 56);
            this.btnTurnoP.TabIndex = 0;
            this.btnTurnoP.Text = "Turno\r\nPresencial";
            this.btnTurnoP.UseVisualStyleBackColor = true;
            this.btnTurnoP.Click += new System.EventHandler(this.btnTurnoP_Click);
            // 
            // btnTurnoV
            // 
            this.btnTurnoV.Location = new System.Drawing.Point(427, 117);
            this.btnTurnoV.Name = "btnTurnoV";
            this.btnTurnoV.Size = new System.Drawing.Size(119, 56);
            this.btnTurnoV.TabIndex = 1;
            this.btnTurnoV.Text = "Turno\r\nVirtual";
            this.btnTurnoV.UseVisualStyleBackColor = true;
            this.btnTurnoV.Click += new System.EventHandler(this.btnTurnoV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Que tipo de turno desea?";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTurnoV);
            this.Controls.Add(this.btnTurnoP);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurnoP;
        private System.Windows.Forms.Button btnTurnoV;
        private System.Windows.Forms.Label label1;
    }
}