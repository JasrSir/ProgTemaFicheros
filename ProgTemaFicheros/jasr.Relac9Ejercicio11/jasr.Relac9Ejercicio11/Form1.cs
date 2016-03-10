/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 11
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 06/03/2016
 *  Comentario: Programa que guarda en un fichero el textohasta introducir una línea vacía y lo muestra en otro form
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
//-----------------------
using System.IO;

namespace jasr.Relac9Ejercicio11
{
    public partial class FormPrincipal : Form
    {
        string ruta = Directory.GetCurrentDirectory() + "\\ArchivoEjercicio11.txt";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void tbx_Texto_TextChanged(object sender, EventArgs e)
        {
            string intro = "\r\n";

            if (tbx_Texto.Text.Length >1)
                if (tbx_Texto.Text[tbx_Texto.Text.Length - 2].ToString() + tbx_Texto.Text[tbx_Texto.Text.Length - 1].ToString() == intro)
                {
                    CrearArchivo(tbx_Texto.Text);
                    MessageBox.Show("Archivo Creado Correctamente", "Atención", MessageBoxButtons.OK);
                    Form ventana = new FormMostrarContenido(ruta);
                    ventana.Show();
                }
        }

        /// <summary>
        /// Método que crea el archivo con el texto introducido
        /// </summary>
        /// <param name="texto">Texto que va a guardar.</param>
        private void CrearArchivo(string texto)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(archivo);
            escritor.WriteLine(texto);
            escritor.Close();
            archivo.Close();
        }

        
    }
}
