using Proyecto_EstructurasDeDatos.Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EstructurasDeDatos
{
    public partial class Form2 : Form
    {
        private Album album;
        private int Cont = 0;

        public Form2(Album album)
        {
            InitializeComponent();
            this.album = album;
            if (album.TipoLista == 0 && album.LDE == null)
            {
                album.LDE = new Listas.ListaDoblementeEnlazada<string>();
            } else if (album.TipoLista == 1 && album.LC == null)
            {
                album.LC = new ListaCircular<string>();
            } else if (album.TipoLista == 2 && album.LSE == null)
            {
                album.LSE = new ListaSimplementeEnlazada<string>();
            }
        }

        public void MostrarAlbum()
        {
            MostrarSiguienteImagen();
        }

        private void MostrarSiguienteImagen()
        {
            Fotos<string> fotos = album.TipoLista == 2 ? album.MostrarFotoSiguienteLSE() : album.MostrarLaFotoSiguiente();
            if (fotos != null)
            {
                try
                {
                    Image imagen = Image.FromFile(fotos.DireccionArchivo);

                    pictureBoxAlbum.Image = imagen;

                    labelInfo.Text = $"ID: {fotos.ID}, Descripcion: {fotos.Descripcion}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                }
            } else
            {
                MessageBox.Show("No hay mas imagenes en el album");
            }
        }

        //Botones der y izq
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSiguienteImagen();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Fotos<string> fotos = album.MostrarFotoAnterior();

            if (fotos != null)
            {
                try
                {
                    Image imagen = Image.FromFile(fotos.DireccionArchivo);

                    pictureBoxAlbum.Image = imagen;

                    labelInfo.Text = $"ID: {fotos.ID}, Descripción: {fotos.Descripcion}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                }
            } else
            {
                MessageBox.Show("No hay más imágenes en el álbum.");
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
                 
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
