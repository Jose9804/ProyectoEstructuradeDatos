using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructurasDeDatos
{
    public class Fotos<T>
    {
        public int ID { get; set; }
        public T Descripcion { get; set; }
        public T DireccionArchivo { get; set; }

        // conectar los nodos
        public Fotos<T> Siguiente { get; set; }
        public Fotos<T> Anterior { get; set; }

        public Fotos(int iD, T descripcion, T direccionArchivo)
        {
            ID = iD;
            Descripcion = descripcion;
            DireccionArchivo = direccionArchivo;
        }

        public Fotos()
        {
        }
    }
}
