/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 1 y 2
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 06/03/2016
 *  Comentario: Programas que... 1- Muestra distinta información de una ruta
 *                               2- Muestra distinta información de un directorio.
 *-------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------
using System.IO;

namespace jasr.Relac9Ejerc1y2
{
    public partial class Frm_VentPrincipal1y2 : Form
    {
        string sl = "\r\n";
        public Frm_VentPrincipal1y2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra Información sobre una ruta en concreta.
        /// </summary>
        private void btn_Extraer_Click(object sender, EventArgs e)
        {
            rtb_InfoPath.Text = string.Empty;
            rtb_InfoPath.Text += Path.GetDirectoryName(lbl_ruta.Text) + sl;
            rtb_InfoPath.Text += Path.GetExtension(lbl_ruta.Text) + sl;
            rtb_InfoPath.Text += Path.GetFileName(lbl_ruta.Text) + sl;
            rtb_InfoPath.Text += Path.GetFileNameWithoutExtension(lbl_ruta.Text) + sl;
            rtb_InfoPath.Text += Path.GetFullPath(lbl_ruta.Text) + sl;
        }

        /// <summary>
        /// Muestra Información sobre un directorio.
        /// </summary>
        private void btn_ElegirArchivo_Click(object sender, EventArgs e)
        {
            DirectoryInfo directorioElegido = null;
            if (fbd_BuscaDirectorio.ShowDialog() == DialogResult.OK && fbd_BuscaDirectorio.SelectedPath != string.Empty)
            {
                directorioElegido = new DirectoryInfo(fbd_BuscaDirectorio.SelectedPath);
                lbl_DirectorioElegido.Text = directorioElegido.ToString();
                lbx_DirectoryInfo.Items.Clear();
                lbx_DirectoryInfo.Items.Add(directorioElegido.FullName);
                lbx_DirectoryInfo.Items.Add(directorioElegido.Name);
                lbx_DirectoryInfo.Items.Add(directorioElegido.CreationTime);
                lbx_DirectoryInfo.Items.Add(directorioElegido.LastAccessTime);
                lbx_DirectoryInfo.Items.Add(directorioElegido.LastWriteTime);
                lbx_DirectoryInfo.Items.Add(directorioElegido.Attributes);
                lbx_DirectoryInfo.Items.Add(directorioElegido.Root);
                lbx_DirectoryInfo.Items.Add(directorioElegido.Parent);
            }
        }
    }
}
