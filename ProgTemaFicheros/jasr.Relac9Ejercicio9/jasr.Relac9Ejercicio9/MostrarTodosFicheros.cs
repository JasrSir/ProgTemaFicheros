/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 9
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 06/03/2016
 *  Comentario: Programa que toma todos los archivos de texto pasados por consola
 *                  y los muestra uno tras otro separadas por una linea horizontal.
 *-------------------------------------------------------------------------------------*/﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------
using System.IO;

namespace jasr.Relac9Ejercicio9
{
    class MostrarTodosFicheros
    {
        //Campo que guarda en un array de boolean si existen los ficheros
        //introducidos o no (true or false).
        static bool[] existenFicheros = null;

        static void Main(string[] args)
        {
            ContarYClasificarFicheros(args);
            ShowAllFiles(existenFicheros, args);
        }
        /// <summary>
        /// Función que clasifica archivos según su existencia.
        /// </summary>
        /// <param name="ficheros">ficheros pasados desde consola</param>
        private static void ContarYClasificarFicheros(string[] ficheros)
        {
            existenFicheros = new bool[ficheros.Length];
            for (int i = 0; i < ficheros.Length; i++)
            {
                if (File.Exists(ficheros[i]))
                    existenFicheros[i] = true;
                else
                    existenFicheros[i] = false;
            }
        }

        /// <summary>
        /// Función que lista el contenido de los ficheros separados por líneas de información
        /// </summary>
        /// <param name="existencia">array de bool que contiene si existen los ficheros o no</param>
        /// <param name="ficheros"> array de string con las rutas de los ficheros introducidos.</param>
        private static void ShowAllFiles(bool[] existencia, string[] ficheros)
        {
            StreamReader streamLector;
            //Recorremos todos los ficheros que hay
            for (int i = 0; i < ficheros.Length; i++)
            {
                if (existencia[i])//Si existe mostramos su contenido
                {
                    Console.WriteLine("".PadRight(Console.WindowWidth, '-'));
                    Console.WriteLine(" -> Contenido del fichero : " + Path.GetFileName(ficheros[i]));
                    Console.WriteLine("".PadRight(Console.WindowWidth, '-'));
                    streamLector = new StreamReader(ficheros[i]);
                    do
                    {
                        Console.WriteLine(streamLector.ReadLine());
                    } while (!streamLector.EndOfStream);

                    streamLector.Close(); //Cerramos el flujo.
                    //Contenido final al terminar el fichero
                    Console.WriteLine("".PadRight(Console.WindowWidth, '-'));
                    Console.WriteLine(" -> FIN DEL CONTENIDO DEL FICHERO : " + Path.GetFileName(ficheros[i]));
                    Console.WriteLine("".PadRight(Console.WindowWidth, '-'));
                }
                else //Si no existe el fichero
                {
                    Console.WriteLine("".PadRight(Console.WindowWidth, '-'));
                    Console.WriteLine(" -> El fichero : " + Path.GetFileName(ficheros[i]) + " NO EXISTE");
                    Console.WriteLine("".PadRight(Console.WindowWidth, '-'));
                } 
            }
        }
        /// <summary>
        /// Función de Ayuda
        /// </summary>
        static void Ayuda()
        {
            Console.WriteLine();
            Console.WriteLine("".PadRight(10, '='));
            Console.WriteLine("[ AYUDA  ]");
            Console.WriteLine("".PadRight(10, '='));
            Console.WriteLine(" Para acceder a este ejercicio se pide que introduzcan argumentos");
            Console.WriteLine("  en este orden.. los () son espacios\n");
            Console.WriteLine(" Nombre_Programa () fichero a mostrar el contenido () fichero a mostrar el contenido () tandos como quiera\n");
            Console.WriteLine(" DEBEN EXISTIR LOS FICHEROS, Sino se saltará ese fichero al mostrarlo.");
        }
    }
}
