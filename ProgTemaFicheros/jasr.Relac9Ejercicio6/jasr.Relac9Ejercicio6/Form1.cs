/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 6
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 06/03/2016
 *  Comentario: Programa que cuenta las veces que aparece 1 carácter en un fichero escogido.
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
//---------------------------
using System.IO;

namespace jasr.Relac9Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AbrirArchivo_Click(object sender, EventArgs e)
        {
            //Abre el cuadro de diálogo y muestra si es OK la ruta en el lbl.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                lbl_RutaArchivo.Text = openFileDialog1.FileName;
        }
        /// <summary>
        /// Función que contabiliza el número de veces que aparece un carácter
        /// </summary>
        /// <param name="ruta">Ruta del archivo a examinar</param>
        /// <param name="caracter">Caracter a contar</param>
        /// <returns>devuelve un entero con las veces que se repite ese caracter</returns>
        private int CuentaCaracterFile(string ruta, char caracter)
        {
            int charRepeticiones = 0;
            char caracterActual;
            StreamReader lecturaArchivo = new StreamReader(ruta);
            do
            {
                if (lecturaArchivo.Peek() != -1)
                {
                    caracterActual = (char)lecturaArchivo.Read();
                    if (caracterActual == caracter)
                        charRepeticiones++;
                }
            } while (lecturaArchivo.Peek()!=-1);
            lecturaArchivo.Close();
            return charRepeticiones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llamamos a la función que cuenta los carácteres y la insertamos en el lbl para mostrarlo
           lbl_Repeticiones.Text = CuentaCaracterFile(lbl_RutaArchivo.Text, char.Parse(txb_Caracter.Text)).ToString();
        }

    }
}
