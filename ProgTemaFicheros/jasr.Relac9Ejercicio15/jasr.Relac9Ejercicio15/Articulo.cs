using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------
using System.IO;

namespace jasr.Relac9Ejercicio15
{
    class Articulo
    {
        string _rutaArchivo = string.Empty;
        FileStream archivo = null;

        /// <summary>
        /// Función que crea el fichero o lo sobreescribe.(9)
        /// </summary>
        public void ArticuloCrear()
        {
            _rutaArchivo = Directory.GetCurrentDirectory() + "\\" + "ArchivoArticulos.txt";
            archivo = File.Create(_rutaArchivo);
        }

        public void ArticuloAlta()
        {
            
        }

        public void ArticuloBaja()
        {

        }

        public void ArticuloListar()
        {

        }
        public void ArticuloConsultar()
        {

        }
        public void ArticuloModificar()
        {

        }
    }
}
