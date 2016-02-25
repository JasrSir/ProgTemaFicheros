using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
using System.IO;

namespace jasr.Relac9Ejercicios3y4
{
    class CopiarArchivos
    { 
        /// <summary>
        /// Método que muestra ayuda en consola si no se introducen correctamente las rutas
        /// de los directorios necesarios.
        /// </summary>
        static void Ayuda()
        {
            Console.WriteLine();
            Console.WriteLine("".PadRight(10,'='));
            Console.WriteLine("[ AYUDA  ]");
            Console.WriteLine("".PadRight(10, '='));
            Console.WriteLine(" Para acceder a estos ejercicios se pide que introduzcan argumentos");
            Console.WriteLine("  en este orden.. los () son espacios\n");
            Console.WriteLine(" El ejercicio 3 copia el contenido de un fichero a otro.");
            Console.WriteLine(" Ejer.3 =  Nombre_Programa () ficheroOrigen () ficheroDestino\n");
            Console.WriteLine(" El ejercicio 4 copia el contenido de un fichero a otro sin el carácter pasado.");
            Console.WriteLine(" Ejer.4 =  Nombre_Programa () ficheroDestino () ficheroFuente () carácter\n");
            Console.WriteLine(" Si no existen los ficheros de DESTINO se creará uno nuevo en el mismo directorio que el archivo original");
            Console.WriteLine(" O si introduces más de 1 carácter en el caso concreto del ejercicio 4, tendrás que repetir la operación");
        }
        /// <summary>
        /// Método que muestra por consola un aviso si no existe algún fichero.
        /// </summary>
        static void NotExists()
        {
            Console.WriteLine(" Alguno de los ficheros introducidos no existe... Inténtalo de nuevo");
        }
        /// <summary>
        /// Método que muestra por consola un aviso si se ha introducido más de un char
        /// </summary>
        static void MasDeUnChar()
        {
            Console.WriteLine("\n".PadRight(75, '='));
            Console.WriteLine(" Has Introducido más de 1 caracter... Solo puede ser 1 solo carácter");
            Console.WriteLine("".PadRight(75, '='));
        }

        static void Main(string[] args)
        {
            //Clasificamos si tiene los argumentos necesarios
            if (args.Length == 2)
            {
                if (!File.Exists(args[0])) //Si existe el archivo de origen
                    NotExists();
                else
                    CopiarArchivo(args[0], args[1]);
            }
            else if (args.Length == 3)
            {
                if (!File.Exists(args[1])) //Si existe el archivo de origen
                    NotExists();
                else if(args[2].Length > 1)
                    MasDeUnChar();
                else if (args.Length == 3)
                    CopiarArchivoSinCaracter(args[1], args[0], char.Parse(args[2]));
            }
            else
                Ayuda();
        }
        static void CopiarArchivo(string archivoOrigen, string archivoDestino)
        {
            string[] textoArchivo;
            if (!File.Exists(archivoDestino))
            {
                archivoDestino = Directory.GetCurrentDirectory()+"\\"+Path.GetFileNameWithoutExtension(archivoOrigen)+"Copia"+ Path.GetExtension(archivoOrigen);
            }
            try
            {
                textoArchivo = File.ReadAllLines(archivoOrigen);
                File.AppendAllLines(archivoDestino, textoArchivo);
                
                Console.WriteLine("\n".PadRight(75, '='));
                Console.WriteLine("--> La Operación ha sido un éxito");
                Console.WriteLine("".PadRight(75, '='));

            }
            catch
            {
                Console.WriteLine("\n".PadRight(75, '='));
                Console.WriteLine("--> [Ha ocurrido algo inesperado, Inténtalo de nuevo]");
                Console.WriteLine("".PadRight(75, '='));
                throw;
            }
            
        }
        static void CopiarArchivoSinCaracter(string rutaDestino , string rutaOrigen, char caracterAQuitar)
        {
            string[] textoArchivo;
            try
            {
                textoArchivo = File.ReadAllLines(rutaOrigen);
                for (int i = 0; i < textoArchivo.Rank; i++)
                {
                    for (int j = 0; j < textoArchivo[i].Length; j++)
                    {
                        //?????
                    }
                }
                Console.WriteLine("\n".PadRight(75, '='));
                Console.WriteLine("--> La Operación ha sido un éxito");
                Console.WriteLine("".PadRight(75, '='));

            }
            catch
            {
                Console.WriteLine("\n".PadRight(75, '='));
                Console.WriteLine("--> [Ha ocurrido algo inesperado, Inténtalo de nuevo]");
                Console.WriteLine("".PadRight(75, '='));
                throw;
            }
        }
    }
}
