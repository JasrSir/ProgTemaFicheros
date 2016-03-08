namespace jasr.Relac9Ejercicio10
{
    partial class FormArchivoAlReves
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
            this.btn_BuscaArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            this.lbl_Características = new System.Windows.Forms.Label();
            this.lbl_TextoAlReves = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BuscaArchivo
            // 
            this.btn_BuscaArchivo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscaArchivo.Location = new System.Drawing.Point(12, 12);
            this.btn_BuscaArchivo.Name = "btn_BuscaArchivo";
            this.btn_BuscaArchivo.Size = new System.Drawing.Size(127, 153);
            this.btn_BuscaArchivo.TabIndex = 0;
            this.btn_BuscaArchivo.Text = "(10) Busca y selecciona un archivo de texto\r\ny (12) muestra características";
            this.btn_BuscaArchivo.UseVisualStyleBackColor = true;
            this.btn_BuscaArchivo.Click += new System.EventHandler(this.btn_BuscaArchivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // lbl_Ruta
            // 
            this.lbl_Ruta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Ruta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ruta.Location = new System.Drawing.Point(161, 13);
            this.lbl_Ruta.Name = "lbl_Ruta";
            this.lbl_Ruta.Size = new System.Drawing.Size(739, 56);
            this.lbl_Ruta.TabIndex = 2;
            this.lbl_Ruta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Características
            // 
            this.lbl_Características.BackColor = System.Drawing.Color.White;
            this.lbl_Características.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Características.Location = new System.Drawing.Point(12, 206);
            this.lbl_Características.Name = "lbl_Características";
            this.lbl_Características.Size = new System.Drawing.Size(127, 285);
            this.lbl_Características.TabIndex = 4;
            // 
            // lbl_TextoAlReves
            // 
            this.lbl_TextoAlReves.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextoAlReves.Location = new System.Drawing.Point(164, 83);
            this.lbl_TextoAlReves.Multiline = true;
            this.lbl_TextoAlReves.Name = "lbl_TextoAlReves";
            this.lbl_TextoAlReves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbl_TextoAlReves.Size = new System.Drawing.Size(736, 408);
            this.lbl_TextoAlReves.TabIndex = 5;
            // 
            // FormArchivoAlReves
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(912, 500);
            this.Controls.Add(this.lbl_TextoAlReves);
            this.Controls.Add(this.lbl_Características);
            this.Controls.Add(this.lbl_Ruta);
            this.Controls.Add(this.btn_BuscaArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormArchivoAlReves";
            this.Text = "Ejercicios 10, 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscaArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_Ruta;
        private System.Windows.Forms.Label lbl_Características;
        private System.Windows.Forms.TextBox lbl_TextoAlReves;
    }
}

