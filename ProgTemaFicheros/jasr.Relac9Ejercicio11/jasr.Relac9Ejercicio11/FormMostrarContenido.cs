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
    public partial class FormMostrarContenido : Form
    {
        public FormMostrarContenido(string ruta)
        {
            InitializeComponent();
            ListarFichero(ruta);
        }

        private void ListarFichero(string fi)
        {
            StreamReader leer = new StreamReader(fi);
            if (leer.EndOfStream)
                 tbx_Mostrar.Text = "No Hay Texto Disponible";
            else
            {
                do
                {
                    tbx_Mostrar.Text += leer.ReadLine()+"\r\n";
                } while (!leer.EndOfStream);

            }
            leer.Close();
        }
    }
}
