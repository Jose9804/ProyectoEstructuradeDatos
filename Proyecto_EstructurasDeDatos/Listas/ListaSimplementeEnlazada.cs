using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructurasDeDatos.Listas
{
    public class ListaSimplementeEnlazada<T>
    {
        public Fotos<T> Primero { get; set; }
        public Fotos<T> Ultimo { get; set; }
        public Fotos<T> Actual3 { get; set; }

        public int ContadorLSEMaximo { get; set; }
        public int ContadorActual { get; set; }

        public ListaSimplementeEnlazada()
        {
            Primero = null;
            Ultimo = null;
            ContadorLSEMaximo = 0;
            ContadorActual = 0;
            Actual3 = null;
        }

        public void AgregarFotos(Fotos<T> newNodo)
        {
            if (Primero == null)
            {
                Primero = newNodo;
                Primero.Siguiente = null;
                Ultimo = newNodo;
                Actual3 = Primero;
            }
            else
            {
                Ultimo.Siguiente = newNodo;
                newNodo.Siguiente = null;
                Ultimo = newNodo;
                Ultimo.Siguiente = null;
            }
            ContadorLSEMaximo++;
        } 
        
        public bool EliminarFotos (Fotos<T> EliNodo)
        {
            bool DE = false;
            Fotos<T> Anterior = null;
            Fotos<T> Actual = null;

            if (Primero != null)
            {
                while(Actual != null && !Actual.ID.Equals(EliNodo.ID))
                {
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (Actual != null)
                {
                    if (Primero.ID.Equals(EliNodo.ID))
                    {
                        Primero = Primero.Siguiente;
                    } else if (Ultimo.ID.Equals(EliNodo.ID))
                    {
                        Anterior.Siguiente = null;
                        Ultimo = Anterior;
                    } else
                    {
                        Anterior.Siguiente = Actual.Siguiente;
                    }
                    DE = true;
                    ContadorLSEMaximo--;
                }
            }
            return DE;
        }
        public Fotos<T> MostrarSiguienteFoto()
        {
            if (Actual3 != null)
            {
                Actual3 = Actual3.Siguiente;
                ContadorActual++;
            }
            return Actual3;
        }
    }
}
