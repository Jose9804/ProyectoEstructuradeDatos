using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructurasDeDatos.Listas
{
    public class ListaCircular<T>
    {
        public Fotos<T> Primero { get; set; }
        public Fotos<T> Ultimo { get; set; }
        public Fotos<T> Actual1 { get; set; }

        public int ContadorLCMaximo { get; set; }
        public int ContadorActual { get; set; }

        public ListaCircular()
        {
            Primero = null;
            Ultimo = null;
        }

        // metodos
        public void AgregarNodo(Fotos<T> newNodo)
        {
            if (Primero == null)
            {
                Primero = newNodo;
                Primero.Siguiente = null;
                Primero.Anterior = null;
                Ultimo = Primero;
            } else
            {
                Ultimo.Siguiente = newNodo;
                newNodo.Siguiente = null;
                newNodo.Anterior = Ultimo;
                Ultimo = newNodo;
                Ultimo.Siguiente = null;
            }
            ContadorLCMaximo++;
        }

        public Fotos<T> MostrarFotos()
        {
            if (Primero != null)
            {
                if (ContadorActual == ContadorLCMaximo)
                {
                    Actual1 = Primero;
                    ContadorActual = 1;
                } else if (ContadorActual != 0 && ContadorActual != ContadorLCMaximo) {
                    Actual1 = Actual1.Siguiente;
                    ContadorActual++;
                } else if (ContadorActual == 0){
                    Actual1 = Primero;
                    ContadorActual++;
                }
            }
            return Actual1;
        }

        public bool EliminarFotos(Fotos<T> EliNodo)
        {
            bool DE = false;
            Fotos<T> Anterior = null;
            Fotos<T> Actual = Primero;
            Fotos<T> Inicio = Primero; 

            if (Primero != null)
            {
                do
                {
                    if (Actual != null && Actual.ID.Equals(EliNodo.ID))
                    {
                        if (Primero.ID.Equals(EliNodo.ID))
                        {
                            Primero = Primero.Siguiente;
                            Ultimo.Siguiente = Primero;
                        }
                        else if (Ultimo.ID.Equals(EliNodo.ID))
                        {
                            Anterior.Siguiente = Primero;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        DE = true;
                        ContadorLCMaximo--;
                        break;
                    }
                    else
                    {
                        Anterior = Actual;
                        Actual = Actual.Siguiente;
                    }
                } while (Actual != Inicio && Actual != null);
            }
            return DE;
        }
    }

}
