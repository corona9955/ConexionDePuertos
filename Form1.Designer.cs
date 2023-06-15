namespace ConexionDePuertos
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
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.cmbxPuertos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(86, 146);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(368, 20);
            this.txtData1.TabIndex = 0;
            // 
            // cmbxPuertos
            // 
            this.cmbxPuertos.FormattingEnabled = true;
            this.cmbxPuertos.Location = new System.Drawing.Point(86, 64);
            this.cmbxPuertos.Name = "cmbxPuertos";
            this.cmbxPuertos.Size = new System.Drawing.Size(196, 21);
            this.cmbxPuertos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbxPuertos);
            this.Controls.Add(this.txtData1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.ComboBox cmbxPuertos;
    }
}

