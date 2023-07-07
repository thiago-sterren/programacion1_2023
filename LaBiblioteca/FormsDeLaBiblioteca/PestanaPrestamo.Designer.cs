namespace FormsDeLaBiblioteca
{
    partial class PestanaPrestamo
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
            this.btnVolverPrestamo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolverPrestamo
            // 
            this.btnVolverPrestamo.Location = new System.Drawing.Point(647, 370);
            this.btnVolverPrestamo.Name = "btnVolverPrestamo";
            this.btnVolverPrestamo.Size = new System.Drawing.Size(102, 46);
            this.btnVolverPrestamo.TabIndex = 2;
            this.btnVolverPrestamo.Text = "Volver";
            this.btnVolverPrestamo.UseVisualStyleBackColor = true;
            this.btnVolverPrestamo.Click += new System.EventHandler(this.btnVolverPrestamo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(367, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // PestanaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnVolverPrestamo);
            this.Name = "PestanaPrestamo";
            this.Text = "PestanaPrestamo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolverPrestamo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}