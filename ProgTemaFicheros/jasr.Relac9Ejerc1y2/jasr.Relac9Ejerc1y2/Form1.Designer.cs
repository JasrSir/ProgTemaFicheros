namespace jasr.Relac9Ejerc1y2
{
    partial class Frm_VentPrincipal1y2
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
            this.btn_Extraer = new System.Windows.Forms.Button();
            this.fbd_BuscaDirectorio = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.lbl_Fondo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1_intro = new System.Windows.Forms.Label();
            this.lbl2_Intro = new System.Windows.Forms.Label();
            this.rtb_InfoPath = new System.Windows.Forms.Label();
            this.btn_ElegirArchivo = new System.Windows.Forms.Button();
            this.lbt_titulo = new System.Windows.Forms.Label();
            this.lbl_DirectorioElegido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx_DirectoryInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Extraer
            // 
            this.btn_Extraer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Extraer.Location = new System.Drawing.Point(697, 12);
            this.btn_Extraer.Name = "btn_Extraer";
            this.btn_Extraer.Size = new System.Drawing.Size(109, 55);
            this.btn_Extraer.TabIndex = 0;
            this.btn_Extraer.Text = "Extraer Info";
            this.btn_Extraer.UseVisualStyleBackColor = true;
            this.btn_Extraer.Click += new System.EventHandler(this.btn_Extraer_Click);
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ruta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruta.Location = new System.Drawing.Point(222, 30);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(390, 26);
            this.lbl_ruta.TabIndex = 1;
            this.lbl_ruta.Text = "c:/basura/basura1/basura2/basura3/texto.txt";
            this.lbl_ruta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Fondo1
            // 
            this.lbl_Fondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.lbl_Fondo1.Location = new System.Drawing.Point(12, 70);
            this.lbl_Fondo1.Name = "lbl_Fondo1";
            this.lbl_Fondo1.Size = new System.Drawing.Size(864, 128);
            this.lbl_Fondo1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 165);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Archivo a Extraer Información";
            // 
            // lbl1_intro
            // 
            this.lbl1_intro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_intro.Location = new System.Drawing.Point(29, 87);
            this.lbl1_intro.Name = "lbl1_intro";
            this.lbl1_intro.Size = new System.Drawing.Size(211, 97);
            this.lbl1_intro.TabIndex = 9;
            this.lbl1_intro.Text = "Nombre del Directorio:\r\nExtensión del Archivo:\r\nNombre del Archivo:\r\nNombre sin e" +
    "xtensión:\r\nRaíz de la Ruta:";
            this.lbl1_intro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2_Intro
            // 
            this.lbl2_Intro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2_Intro.Location = new System.Drawing.Point(29, 322);
            this.lbl2_Intro.Name = "lbl2_Intro";
            this.lbl2_Intro.Size = new System.Drawing.Size(211, 148);
            this.lbl2_Intro.TabIndex = 10;
            this.lbl2_Intro.Text = "Nombre Completo:\r\nNombre del Archivo:\r\nFecha Creación:\r\nFecha último acceso:\r\nFec" +
    "ha última lectura:\r\nAtributos:\r\nRaíz:\r\nCarpeta Padre:\r\n";
            this.lbl2_Intro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtb_InfoPath
            // 
            this.rtb_InfoPath.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_InfoPath.Location = new System.Drawing.Point(246, 87);
            this.rtb_InfoPath.Name = "rtb_InfoPath";
            this.rtb_InfoPath.Size = new System.Drawing.Size(616, 97);
            this.rtb_InfoPath.TabIndex = 11;
            this.rtb_InfoPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ElegirArchivo
            // 
            this.btn_ElegirArchivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ElegirArchivo.Location = new System.Drawing.Point(15, 247);
            this.btn_ElegirArchivo.Name = "btn_ElegirArchivo";
            this.btn_ElegirArchivo.Size = new System.Drawing.Size(109, 55);
            this.btn_ElegirArchivo.TabIndex = 13;
            this.btn_ElegirArchivo.Text = "Busca tu Carpeta";
            this.btn_ElegirArchivo.UseVisualStyleBackColor = true;
            this.btn_ElegirArchivo.Click += new System.EventHandler(this.btn_ElegirArchivo_Click);
            // 
            // lbt_titulo
            // 
            this.lbt_titulo.AutoSize = true;
            this.lbt_titulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbt_titulo.Location = new System.Drawing.Point(136, 239);
            this.lbt_titulo.Name = "lbt_titulo";
            this.lbt_titulo.Size = new System.Drawing.Size(153, 18);
            this.lbt_titulo.TabIndex = 15;
            this.lbt_titulo.Text = "Directorio Elegido";
            // 
            // lbl_DirectorioElegido
            // 
            this.lbl_DirectorioElegido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DirectorioElegido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DirectorioElegido.Location = new System.Drawing.Point(139, 257);
            this.lbl_DirectorioElegido.Name = "lbl_DirectorioElegido";
            this.lbl_DirectorioElegido.Size = new System.Drawing.Size(723, 56);
            this.lbl_DirectorioElegido.TabIndex = 14;
            this.lbl_DirectorioElegido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(-2, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(890, 10);
            this.label3.TabIndex = 16;
            // 
            // lbx_DirectoryInfo
            // 
            this.lbx_DirectoryInfo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_DirectoryInfo.FormattingEnabled = true;
            this.lbx_DirectoryInfo.ItemHeight = 18;
            this.lbx_DirectoryInfo.Location = new System.Drawing.Point(249, 322);
            this.lbx_DirectoryInfo.Name = "lbx_DirectoryInfo";
            this.lbx_DirectoryInfo.Size = new System.Drawing.Size(613, 148);
            this.lbx_DirectoryInfo.TabIndex = 17;
            // 
            // Frm_VentPrincipal1y2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 492);
            this.Controls.Add(this.lbx_DirectoryInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbt_titulo);
            this.Controls.Add(this.lbl_DirectorioElegido);
            this.Controls.Add(this.btn_ElegirArchivo);
            this.Controls.Add(this.rtb_InfoPath);
            this.Controls.Add(this.lbl2_Intro);
            this.Controls.Add(this.lbl1_intro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Fondo1);
            this.Controls.Add(this.lbl_ruta);
            this.Controls.Add(this.btn_Extraer);
            this.Name = "Frm_VentPrincipal1y2";
            this.Text = "Relacion 9, Ejercicios 1 y 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Extraer;
        private System.Windows.Forms.FolderBrowserDialog fbd_BuscaDirectorio;
        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.Label lbl_Fondo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1_intro;
        private System.Windows.Forms.Label lbl2_Intro;
        private System.Windows.Forms.Label rtb_InfoPath;
        private System.Windows.Forms.Button btn_ElegirArchivo;
        private System.Windows.Forms.Label lbt_titulo;
        private System.Windows.Forms.Label lbl_DirectorioElegido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx_DirectoryInfo;
    }
}

