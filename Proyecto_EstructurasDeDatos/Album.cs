using Proyecto_EstructurasDeDatos.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EstructurasDeDatos
{
    public class Album
    {
        public ListaSimplementeEnlazada<string> LSE = new ListaSimplementeEnlazada<string>();
        public ListaDoblementeEnlazada<string> LDE = new ListaDoblementeEnlazada<string>();
        public ListaCircular<string> LC = new ListaCircular<string>();

        Fotos<string> Actual = new Fotos<string>();

        public int Contador = 0;
        public int TipoLista { get; set; }

        public Album()
        {
        }

        public void AñadirFoto(Fotos<string> fotos)
        {
            LSE.AgregarFotos(fotos);
            LDE.AgregarFoto(fotos);
            LC.AgregarNodo(fotos);
        }

        public void EliminarFoto(int Id)
        {
            string ward = "";
            Fotos<string> EliNodo = new Fotos<string>
            {
                ID = Id
            };
            bool BorradoLSE = LSE.EliminarFotos(EliNodo);
            bool BorradoLDE = LDE.EliminarFotos(EliNodo);
            bool BorradoLC = LC.EliminarFotos(EliNodo);

            if (BorradoLDE == true)
            {
                string DelLDE = "Lista Doblemente Eliminada: Ha sido Eliminado Correctamente";
                ward = ward + DelLDE;
            }
            if (BorradoLC == true)
            {
                string DelLC = "\nLista Circular Eliminada: Ha sido Eliminada Correctamente";
                ward = ward + DelLC;
            }
            if (BorradoLSE == true)
            {
                string DelLSE = "\nLista Simplemente Enlazada Eliminada: Ha sido Eliminada Correctamente";
                ward = ward + DelLSE;
            }
            MessageBox.Show(ward, "Se ejecuto Correctamente", MessageBoxButtons.OK);
        }

        public Fotos<string> MostrarLaFotoSiguiente()
        {
            if (TipoLista == 0)
            {
                Actual = LDE.MostrarSiguienteFoto();
                if (Contador != LDE.ContadorLDEMaximo)
                {
                    Contador++;
                }
            }
            if (TipoLista == 1)
            {
                Actual = LC.MostrarFotos();
                if (Contador == LC.ContadorLCMaximo)
                {
                    Contador = 0;
                }
                else Contador++;
            }
            if(TipoLista == 2)
            {
                Actual = LSE.MostrarSiguienteFoto();
                if (Actual != null)
                {
                    Contador--;
                }
            }
            return Actual;
        }

        public Fotos<string> MostrarFotoAnterior()
        {
            if (TipoLista == 0)
            {
                Actual = LDE.MostrarAnteriorFoto();
                Contador--;
            }
            return Actual;
        }

        public void InicialidarListas()
        {
            LDE.ContadorActual = 0;
            LC.ContadorActual = 0;
            LSE.ContadorActual = 0;
        }

        public Fotos<string> MostrarFotoSiguienteLSE()
        {
            Actual = LSE.MostrarSiguienteFoto();
            if (Actual != null)
            {
                Contador++;
            }
            return Actual;
        }
    }
}
