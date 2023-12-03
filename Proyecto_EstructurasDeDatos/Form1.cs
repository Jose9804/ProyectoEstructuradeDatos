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
    public partial class Form1 : Form
    {
        int IDE = 0;
        int FID = 0;
        public int TipoDeLista { get; set; }

        // fotos
        Album album = new Album();

        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = "0";
            DescripciontextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDE = int.Parse(IDtextBox.Text);
            string Desc = DescripciontextBox.Text;
            string Ruta = rutaArchivotextBox.Text;
            Fotos<string> fotos = new Fotos<string>
            {
                ID = IDE,
                Descripcion = Desc,
                DireccionArchivo = Ruta
            };
            album.AñadirFoto(fotos);
            int I = GridView.Rows.Add();

            GridView.Rows[I].Cells[0].Value = fotos.ID;
            GridView.Rows[I].Cells[1].Value = fotos.Descripcion;
            GridView.Rows[I].Cells[2].Value = fotos.DireccionArchivo;
            IDE++;
            LimpiarCajas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (FID != -1)
            {
                if (IDtextBox.Text is null)
                {
                    return;
                }
                IDE = int.Parse(IDtextBox.Text);
                GridView.Rows.RemoveAt(FID);
            }
            album.EliminarFoto(IDE);
            LimpiarCajas();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivotextBox.Text = openFileDialog.FileName;
                DescripciontextBox.Text = openFileDialog.SafeFileName;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FID = e.RowIndex;
            IDtextBox.Text = GridView.Rows[FID].Cells[0].Value.ToString();
        }
        private void LimpiarCajas()
        {
            IDtextBox.Text = IDE.ToString();
            DescripciontextBox.Clear();
            rutaArchivotextBox.Clear();
            DescripciontextBox.Focus();
        }
        private void btnLineaCircular_Click_1(object sender, EventArgs e)
        {
            album.TipoLista = 1;
            Form2 Galeria = new Form2(album);
            Galeria.MostrarAlbum();
            Galeria.ShowDialog();
        }

        private void btnDoblementeEnlazada_Click(object sender, EventArgs e)
        {
            album.TipoLista = 0;
            AbrirForm2();
        }
        private void btnEnlaceSimple_Click(object sender, EventArgs e)
        {
            album.TipoLista = 2;
            Form2 Galeria = new Form2(album);
            Galeria.MostrarAlbum();
            Galeria.ShowDialog();
        }

        private void AbrirForm2()
        {
            Form2 Galeria = new Form2(album);
            Galeria.MostrarAlbum();
            Galeria.ShowDialog();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
