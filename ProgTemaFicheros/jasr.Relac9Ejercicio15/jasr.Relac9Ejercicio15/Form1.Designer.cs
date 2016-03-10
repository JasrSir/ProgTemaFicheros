namespace jasr.Relac9Ejercicio15
{
    partial class VentanaPrincipal
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
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Html = new System.Windows.Forms.Button();
            this.grbx_Listar = new System.Windows.Forms.GroupBox();
            this.rdbtn_Nombre = new System.Windows.Forms.RadioButton();
            this.rdbtn_Codigo = new System.Windows.Forms.RadioButton();
            this.btn_CrearFichero = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.grbx_Listar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Alta
            // 
            this.btn_Alta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alta.Location = new System.Drawing.Point(21, 12);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(105, 50);
            this.btn_Alta.TabIndex = 0;
            this.btn_Alta.Text = "Alta de Artículo";
            this.btn_Alta.UseVisualStyleBackColor = true;
            // 
            // btn_Baja
            // 
            this.btn_Baja.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baja.Location = new System.Drawing.Point(21, 68);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(105, 50);
            this.btn_Baja.TabIndex = 1;
            this.btn_Baja.Text = "Baja de Artículo";
            this.btn_Baja.UseVisualStyleBackColor = true;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.Location = new System.Drawing.Point(162, 12);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(105, 50);
            this.btn_Consultar.TabIndex = 2;
            this.btn_Consultar.Text = "Consultar Artículo";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(162, 68);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(105, 50);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar Artículo";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Html
            // 
            this.btn_Html.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Html.Location = new System.Drawing.Point(306, 12);
            this.btn_Html.Name = "btn_Html";
            this.btn_Html.Size = new System.Drawing.Size(105, 50);
            this.btn_Html.TabIndex = 4;
            this.btn_Html.Text = "Convertir HTML";
            this.btn_Html.UseVisualStyleBackColor = true;
            // 
            // grbx_Listar
            // 
            this.grbx_Listar.BackColor = System.Drawing.SystemColors.Control;
            this.grbx_Listar.Controls.Add(this.rdbtn_Codigo);
            this.grbx_Listar.Controls.Add(this.rdbtn_Nombre);
            this.grbx_Listar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbx_Listar.Location = new System.Drawing.Point(555, 22);
            this.grbx_Listar.Name = "grbx_Listar";
            this.grbx_Listar.Size = new System.Drawing.Size(146, 86);
            this.grbx_Listar.TabIndex = 5;
            this.grbx_Listar.TabStop = false;
            this.grbx_Listar.Text = "Listar Por (elige)";
            // 
            // rdbtn_Nombre
            // 
            this.rdbtn_Nombre.AutoSize = true;
            this.rdbtn_Nombre.Location = new System.Drawing.Point(22, 28);
            this.rdbtn_Nombre.Name = "rdbtn_Nombre";
            this.rdbtn_Nombre.Size = new System.Drawing.Size(86, 22);
            this.rdbtn_Nombre.TabIndex = 0;
            this.rdbtn_Nombre.TabStop = true;
            this.rdbtn_Nombre.Text = "Nombre";
            this.rdbtn_Nombre.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Codigo
            // 
            this.rdbtn_Codigo.AutoSize = true;
            this.rdbtn_Codigo.Location = new System.Drawing.Point(22, 56);
            this.rdbtn_Codigo.Name = "rdbtn_Codigo";
            this.rdbtn_Codigo.Size = new System.Drawing.Size(78, 22);
            this.rdbtn_Codigo.TabIndex = 1;
            this.rdbtn_Codigo.TabStop = true;
            this.rdbtn_Codigo.Text = "Código";
            this.rdbtn_Codigo.UseVisualStyleBackColor = true;
            // 
            // btn_CrearFichero
            // 
            this.btn_CrearFichero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearFichero.Location = new System.Drawing.Point(306, 68);
            this.btn_CrearFichero.Name = "btn_CrearFichero";
            this.btn_CrearFichero.Size = new System.Drawing.Size(105, 50);
            this.btn_CrearFichero.TabIndex = 6;
            this.btn_CrearFichero.Text = "Crear Fichero";
            this.btn_CrearFichero.UseVisualStyleBackColor = true;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.Location = new System.Drawing.Point(433, 36);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(105, 50);
            this.btn_Imprimir.TabIndex = 7;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(723, 466);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_CrearFichero);
            this.Controls.Add(this.grbx_Listar);
            this.Controls.Add(this.btn_Html);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Name = "VentanaPrincipal";
            this.Text = "Gestión de Artículos";
            this.grbx_Listar.ResumeLayout(false);
            this.grbx_Listar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Html;
        private System.Windows.Forms.GroupBox grbx_Listar;
        private System.Windows.Forms.RadioButton rdbtn_Codigo;
        private System.Windows.Forms.RadioButton rdbtn_Nombre;
        private System.Windows.Forms.Button btn_CrearFichero;
        private System.Windows.Forms.Button btn_Imprimir;
    }
}

