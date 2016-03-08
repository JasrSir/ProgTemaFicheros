/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 8
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 06/03/2016
 *  Comentario: Programa que guarda una lista de los alumnos y los muestra (fichero)
 *-------------------------------------------------------------------------------------*/﻿
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

namespace jasr.Relac9Ejercicio8
{
    public partial class AlumnosYLista : Form
    {
        FileStream archivoAlumnos = null;
        StreamReader leerAlumnos = null;
        StreamWriter aniadirAlumnos = null;
        private string rutaArchivo = Directory.GetCurrentDirectory() + "\\ArchivosAlumnos.txt";

        public AlumnosYLista()
        {
            InitializeComponent();
        }

        private void CrearFichero(string fi)
        {
                if (!File.Exists(rutaArchivo))
                {
                    archivoAlumnos = File.Create(rutaArchivo);
                    archivoAlumnos.Close();
                }  
            aniadirAlumnos = new StreamWriter(fi, true);
            //Se escribe entero si los 2 label son distintos de empty y diferencia en los casos.
            if (tbx_Nombre.Text != string.Empty && tbx_Apellido.Text != string.Empty)
                aniadirAlumnos.WriteLine(tbx_Apellido.Text + ", " + tbx_Nombre.Text);
            else if (tbx_Nombre.Text == string.Empty && tbx_Apellido.Text != string.Empty)
                aniadirAlumnos.WriteLine(tbx_Apellido.Text + ", Sin Nombre");
            else if (tbx_Nombre.Text != string.Empty && tbx_Apellido.Text == string.Empty)
                aniadirAlumnos.WriteLine("Sin Apellidos, " + tbx_Nombre.Text);
            aniadirAlumnos.Close();
        }
        private void ListarFichero(string fi)
        {
            if (!File.Exists(fi))
                CrearFichero(fi);

            leerAlumnos = new StreamReader(fi);
            if (leerAlumnos.EndOfStream)
                lbx_ListarAlumnos.Items.Add("No Hay Alumnos Disponibles");
            else
            {
                //Limpiamos la lista y añadimos los alumnos.
                lbx_ListarAlumnos.Items.Clear();
                do
                {
                    lbx_ListarAlumnos.Items.Add(leerAlumnos.ReadLine());
                } while (!leerAlumnos.EndOfStream);
                
            }
            leerAlumnos.Close();
        }
        private void btn_Aniadir_Click(object sender, EventArgs e)
        {
            CrearFichero(rutaArchivo);
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            ListarFichero(rutaArchivo);
        }
    }
}
