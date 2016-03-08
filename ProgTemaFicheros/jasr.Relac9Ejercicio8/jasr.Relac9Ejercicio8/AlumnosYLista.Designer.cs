namespace jasr.Relac9Ejercicio8
{
    partial class AlumnosYLista
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
            this.btn_Aniadir = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.tbx_Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_ListarAlumnos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Aniadir
            // 
            this.btn_Aniadir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aniadir.Location = new System.Drawing.Point(95, 301);
            this.btn_Aniadir.Name = "btn_Aniadir";
            this.btn_Aniadir.Size = new System.Drawing.Size(146, 52);
            this.btn_Aniadir.TabIndex = 0;
            this.btn_Aniadir.Text = "Añade Alumno";
            this.btn_Aniadir.UseVisualStyleBackColor = true;
            this.btn_Aniadir.Click += new System.EventHandler(this.btn_Aniadir_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.Location = new System.Drawing.Point(511, 301);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(146, 52);
            this.btn_Listar.TabIndex = 1;
            this.btn_Listar.Text = "Listar Alumnos";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 360);
            this.label1.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Nombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(35, 36);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(145, 18);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre Alumno:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Apellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(35, 137);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(157, 18);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellidos Alumno:";
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Nombre.Location = new System.Drawing.Point(63, 73);
            this.tbx_Nombre.MaxLength = 30;
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(196, 27);
            this.tbx_Nombre.TabIndex = 5;
            // 
            // tbx_Apellido
            // 
            this.tbx_Apellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Apellido.Location = new System.Drawing.Point(63, 185);
            this.tbx_Apellido.MaxLength = 40;
            this.tbx_Apellido.Name = "tbx_Apellido";
            this.tbx_Apellido.Size = new System.Drawing.Size(228, 27);
            this.tbx_Apellido.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(393, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 360);
            this.label2.TabIndex = 7;
            // 
            // lbx_ListarAlumnos
            // 
            this.lbx_ListarAlumnos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_ListarAlumnos.FormattingEnabled = true;
            this.lbx_ListarAlumnos.ItemHeight = 18;
            this.lbx_ListarAlumnos.Location = new System.Drawing.Point(407, 22);
            this.lbx_ListarAlumnos.Name = "lbx_ListarAlumnos";
            this.lbx_ListarAlumnos.Size = new System.Drawing.Size(338, 256);
            this.lbx_ListarAlumnos.TabIndex = 8;
            // 
            // AlumnosYLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(772, 381);
            this.Controls.Add(this.lbx_ListarAlumnos);
            this.Controls.Add(this.tbx_Apellido);
            this.Controls.Add(this.tbx_Nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Aniadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "AlumnosYLista";
            this.Text = "Introduce Alumnos y lístalos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aniadir;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.TextBox tbx_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx_ListarAlumnos;
    }
}

