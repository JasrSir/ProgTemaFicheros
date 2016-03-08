/*---------------------------------------------------------------------------------------
 *      Nombre: Relacion 9. Ejercicio 
 *       Autor: Juan Antonio Suárez
 *     Versión: 1.0
 *       Fecha: 06/03/2016
 *  Comentario: Función que concatena el contenido de un archivo en otro. Ambos como parámetros.
 *-------------------------------------------------------------------------------------*/﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------
using System.IO;

namespace jasr.Relac9Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                ConcatenaArchivos(args[0], args[1]);
                Console.WriteLine("  ---> DONE! :)");
            }
            else
                Ayuda();
            
                
        }
        /// <summary>
        /// Función que concatena un fichero sobre otro, anexándolo a este.
        /// </summary>
        /// <param name="ficheroAUnir">Fichero donde se guarda e otro archivo</param>
        /// <param name="ficheroACopiar">Fichero a copiar su contenido</param>
        static void ConcatenaArchivos(string ficheroAUnir, string ficheroACopiar)
        {
            //Si existen se realiza el método.
            if (File.Exists(ficheroAUnir) && File.Exists(ficheroACopiar))
            {
                //Se abren flujos de Lectura y escritura para los archivos
                StreamReader lectura = new StreamReader(ficheroACopiar);
                StreamWriter escritura = new StreamWriter(ficheroAUnir, true);
                //Recorremos el de lecura linea a línea mientras se escribe al
                // final del fichero de escritura
                while (!lectura.EndOfStream)
                {
                escritura.WriteLine(lectura.ReadLine());
                }
                //Se cierran los flujos
                lectura.Close();
                escritura.Close();
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
            Console.WriteLine(" Nombre_Programa () fichero a escribir el contenido () dichero a copiar el contenido\n");
            Console.WriteLine(" DEBEN EXISTIR AMBOS FICHEROS, Sino no hará nada.");
        }
    }
}
