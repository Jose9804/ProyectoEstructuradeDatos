using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructurasDeDatos.Listas
{
    public class ListaDoblementeEnlazada<T>
    {
        public Fotos<T> Primero { get; set; }
        public Fotos<T> Ultimo { get; set; }
        public Fotos<T> Actual2 { get; set; }

        public int ContadorLDEMaximo { get; set; }
        public int ContadorActual { get; set; }

        public ListaDoblementeEnlazada()
        {
            Primero = null;
            Ultimo = null;
        }

        public void AgregarFoto(Fotos<T> newNodo)
        {
            if (Primero == null)
            {
                Primero = newNodo;
                Primero.Siguiente = null;
                Primero.Anterior = null;
                Ultimo = Primero;
            }
            else
            {
                Ultimo.Siguiente = newNodo;
                newNodo.Siguiente = null;
                newNodo.Anterior = Ultimo;
                Ultimo = newNodo;
                Ultimo.Siguiente = null;
            }
            ContadorLDEMaximo++;
        }

        public Fotos<T> MostrarSiguienteFoto()
        {
            if (Primero != null)
            {
                if (Actual2 == Ultimo)
                {
                    return Actual2;
                } else if (ContadorActual == ContadorLDEMaximo)
                {
                    Actual2 = Ultimo;
                } else if (ContadorActual != 0 && ContadorActual != ContadorLDEMaximo)
                {
                    Actual2 = Actual2.Siguiente;
                    ContadorActual++;
                } else if (ContadorActual == 0)
                {
                    Actual2 = Primero;
                    ContadorActual++;
                }
            }
            return Actual2;
        }

        public Fotos<T> MostrarAnteriorFoto()
        {
            if (Primero != null)
            {
                if (ContadorActual == ContadorLDEMaximo)
                {
                    Actual2 = Actual2.Anterior;
                    ContadorActual--;
                } else if (ContadorActual != 0 && ContadorActual != ContadorLDEMaximo)
                {
                    Actual2 = Actual2.Anterior;
                    ContadorActual--;
                } else if (ContadorActual == 0)
                {
                    Actual2 = Primero;
                }
            }
            return Actual2;
        }

        public bool EliminarFotos(Fotos<T> EliNodo)
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
                } if (Actual != null)
                {
                    if (Primero.ID.Equals (EliNodo.ID))
                    {
                        Primero = Primero.Siguiente;
                        if(Primero != null)
                        {
                            Primero.Anterior = null;
                        }
                    } else if (Ultimo.ID.Equals(EliNodo.ID))
                    {
                        Anterior.Siguiente = null;
                        Ultimo = Anterior;
                    } else
                    {
                        Anterior.Siguiente = Actual.Siguiente;
                        if (Actual.Siguiente != null)
                        {
                            Actual.Siguiente.Anterior = Anterior;
                        }
                    }
                    DE = true;
                    ContadorLDEMaximo--;
                }
            }
            return DE;
        }
    }
}
