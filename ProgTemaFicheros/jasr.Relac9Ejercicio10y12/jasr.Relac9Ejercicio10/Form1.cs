/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 10 y 12
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 09/03/2016
 *  Comentario: Programa que muestra un archvo al revés(10) y mosrar algunas características (12).
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
//--------------------------
using System.IO;

namespace jasr.Relac9Ejercicio10
{
    public partial class FormArchivoAlReves : Form
    {
        public FormArchivoAlReves()
        {
            InitializeComponent();
        }

        private void btn_BuscaArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_Ruta.Text = openFileDialog1.FileName;
                lbl_TextoAlReves.Text = ArchivoAlReves(lbl_Ruta.Text);
                Caracteristicas(lbl_Ruta.Text);
            }
        }
        /// <summary>
        /// Función que invierte el contenido de un archivo
        /// </summary>
        /// <param name="ruta">ruta del archivo que recibe</param>
        /// <returns>Devuelve un string con el contenido al revés</returns>
        private string ArchivoAlReves(string ruta)
        {
            FileStream archivo = null;

            try
            {
                if (File.Exists(ruta))
                    archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                char aux = ' ';
                string contenido = string.Empty;
                
                for (int i = 0; i < archivo.Length; i++)
                {
                    archivo.Position = archivo.Seek(-i -1, SeekOrigin.End);
                    aux = (char)archivo.ReadByte();
                    if (aux =='\n')
                    {
                        contenido += "\r\n";
                        continue;
                    }
                    contenido += aux;
                }
                return contenido;
            }
            catch
            {
                return lbl_TextoAlReves.Text = "NO SE HA ENCONTRADO TEXTO O EL ARCHIVO NO EXISTE";
            }
            finally
            {
                archivo.Close();
            }
        }
        /// <summary>
        /// Funcion que lee algunas características del fichero
        /// </summary>
        /// <param name="ruta">ruta del fichero a comprobar.</param>
        private void Caracteristicas(string ruta)
        {
            char aux = ' ';
            int numPalabras = 0;
            try 
	        {	        
	            FileStream archivo = new FileStream(ruta, FileMode.Open ,FileAccess.Read);
                lbl_Características.Text = " Líneas: \n    " + File.ReadAllLines(ruta).Length.ToString();
                lbl_Características.Text += "\n Atributos: \n    " + File.GetAttributes(ruta).ToString();
                lbl_Características.Text += "\n Tamaño en Bytes: \n    " + 	archivo.Length.ToString();

                for (int i = 0; i < archivo.Length; i++)
                {
                    aux = (char)archivo.ReadByte();
                    if (aux == ' ')
                        numPalabras++;
                }
                lbl_Características.Text += "\n Nº de Palabras: \n    " + numPalabras.ToString();
                archivo.Close();
            }
	        catch (Exception)
	        {
                throw;
	        }
            
        }
    }
}
