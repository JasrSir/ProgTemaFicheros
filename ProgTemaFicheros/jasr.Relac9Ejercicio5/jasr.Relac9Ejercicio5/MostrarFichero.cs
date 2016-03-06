/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 5
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 06/03/2016
 *  Comentario: Programa que muestra por pantalla el contenido de un fichero de texto.
 *-------------------------------------------------------------------------------------*/﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
using System.IO;

namespace jasr.Relac9Ejercicio5
{
    class MostrarFichero
    {

        static void Main(string[] args)
        {
            if (args.Length != 1 || !File.Exists(args[0]))
                Error();
            else
                MostrarArchivo(args[0]);
        }

        /// <summary>
        /// Función que muestra por consola si ha ocurrido un error en el proceso.
        /// </summary>
        private static void Error()
        {
            Console.WriteLine("".PadRight(50,'~'));
            Console.WriteLine("-> Ha ocurrido un error, Inténtalo de nuevo.");
            Console.WriteLine("".PadRight(50, '~'));
        }
        /// <summary>
        /// Función que abre un archivo y lee cada línea mostrándola por consola.
        /// </summary>
        /// <param name="ruta">Ruta del archivo de texto introducida.</param>
        private static void MostrarArchivo(string ruta)
        {
            //Creamos un flujo de lectura de un archivo abierto para leer.
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader flujoLectura = new StreamReader(archivo);

            Console.WriteLine("".PadRight(50, '~'));
            Console.WriteLine(" -------> Contenido del archivo " + archivo.Name);
            Console.WriteLine("".PadRight(50, '~'));
            do
            { //Leer las líneas de el archivo de texto y las escribe por pantalla.
                Console.WriteLine(flujoLectura.ReadLine());
            } while (!flujoLectura.EndOfStream);

            Console.WriteLine("".PadRight(50, '~'));
            Console.WriteLine(" ------->FIN DEL ARCHIVO ");
            Console.WriteLine("".PadRight(50, '~'));
            //Cerramos el archivo y flujo.
            archivo.Close();
            flujoLectura.Close();
        }
    }
}
