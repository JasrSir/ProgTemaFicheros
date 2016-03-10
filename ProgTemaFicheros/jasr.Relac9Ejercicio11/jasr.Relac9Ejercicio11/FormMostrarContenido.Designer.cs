namespace jasr.Relac9Ejercicio11
{
    partial class FormMostrarContenido
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
            this.tbx_Mostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_Mostrar
            // 
            this.tbx_Mostrar.Location = new System.Drawing.Point(12, 12);
            this.tbx_Mostrar.Multiline = true;
            this.tbx_Mostrar.Name = "tbx_Mostrar";
            this.tbx_Mostrar.Size = new System.Drawing.Size(605, 372);
            this.tbx_Mostrar.TabIndex = 0;
            // 
            // FormMostrarContenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 396);
            this.Controls.Add(this.tbx_Mostrar);
            this.Name = "FormMostrarContenido";
            this.Text = "Muestra del contenido del fichero creado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Mostrar;
    }
}