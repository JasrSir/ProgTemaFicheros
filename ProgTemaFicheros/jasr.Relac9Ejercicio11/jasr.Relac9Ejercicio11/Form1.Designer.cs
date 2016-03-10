namespace jasr.Relac9Ejercicio11
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_Texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_Texto
            // 
            this.tbx_Texto.Location = new System.Drawing.Point(12, 12);
            this.tbx_Texto.Multiline = true;
            this.tbx_Texto.Name = "tbx_Texto";
            this.tbx_Texto.Size = new System.Drawing.Size(512, 260);
            this.tbx_Texto.TabIndex = 0;
            this.tbx_Texto.TextChanged += new System.EventHandler(this.tbx_Texto_TextChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 284);
            this.Controls.Add(this.tbx_Texto);
            this.Name = "FormPrincipal";
            this.Text = "Introduce texto hasta pulsar intro . Crearé un archivo con tu texto ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Texto;
    }
}

