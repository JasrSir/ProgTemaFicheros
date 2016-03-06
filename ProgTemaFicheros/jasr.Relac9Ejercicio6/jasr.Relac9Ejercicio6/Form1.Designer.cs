namespace jasr.Relac9Ejercicio6
{
    partial class Form1
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
            this.btn_AbrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Caracter = new System.Windows.Forms.TextBox();
            this.lbl_RutaArchivo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Repeticiones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AbrirArchivo
            // 
            this.btn_AbrirArchivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirArchivo.Location = new System.Drawing.Point(15, 22);
            this.btn_AbrirArchivo.Name = "btn_AbrirArchivo";
            this.btn_AbrirArchivo.Size = new System.Drawing.Size(133, 46);
            this.btn_AbrirArchivo.TabIndex = 0;
            this.btn_AbrirArchivo.Text = "Busca Archivo";
            this.btn_AbrirArchivo.UseVisualStyleBackColor = true;
            this.btn_AbrirArchivo.Click += new System.EventHandler(this.btn_AbrirArchivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce el caracter a contar";
            // 
            // txb_Caracter
            // 
            this.txb_Caracter.CausesValidation = false;
            this.txb_Caracter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Caracter.Location = new System.Drawing.Point(270, 104);
            this.txb_Caracter.MaxLength = 1;
            this.txb_Caracter.Name = "txb_Caracter";
            this.txb_Caracter.Size = new System.Drawing.Size(31, 27);
            this.txb_Caracter.TabIndex = 2;
            // 
            // lbl_RutaArchivo
            // 
            this.lbl_RutaArchivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_RutaArchivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RutaArchivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_RutaArchivo.Location = new System.Drawing.Point(173, 9);
            this.lbl_RutaArchivo.Name = "lbl_RutaArchivo";
            this.lbl_RutaArchivo.Size = new System.Drawing.Size(481, 73);
            this.lbl_RutaArchivo.TabIndex = 3;
            this.lbl_RutaArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Busca el caracter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "El carácter se repite          Veces";
            // 
            // lbl_Repeticiones
            // 
            this.lbl_Repeticiones.AutoSize = true;
            this.lbl_Repeticiones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Repeticiones.Location = new System.Drawing.Point(499, 160);
            this.lbl_Repeticiones.Name = "lbl_Repeticiones";
            this.lbl_Repeticiones.Size = new System.Drawing.Size(38, 18);
            this.lbl_Repeticiones.TabIndex = 6;
            this.lbl_Repeticiones.Text = "     ";
            this.lbl_Repeticiones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 204);
            this.Controls.Add(this.lbl_Repeticiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_RutaArchivo);
            this.Controls.Add(this.txb_Caracter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AbrirArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AbrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Caracter;
        private System.Windows.Forms.Label lbl_RutaArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Repeticiones;
    }
}

