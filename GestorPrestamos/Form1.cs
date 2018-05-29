using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPrestamos
{
    public partial class Form1 : Form
    {
        List<Libro> listaLibros = new List<Libro>();
        List<Libro> mochilaLibros = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
            listaLibros.Add(new Libro("00001", "El Hobbit", 25.00, "7896541230", "Tolkien", "ALF"));
            listaLibros.Add(new Libro("00002", "El Señor de los Anillos", 50.00, "7896789230", "Tolkien", "ALF"));
            listaLibros.Add(new Libro("00003", "El Silmarilion", 30.00, "7896789477", "Tolkien", "ALF"));

            LoadListViewLibros();
        }

        private void LoadListViewLibros()
        {
            listViewLibros.Clear();
            listViewLibros.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            ListView.ListViewItemCollection listaLd = 
                new ListView.ListViewItemCollection(listViewLibros);

            foreach(Libro l in listaLibros)
            {
                listaLd.Add(l.ToString(), 0);
            }

            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile("E:\\copia_segur\\libro.png"));
            imageListLarge.Images.Add(Bitmap.FromFile("E:\\copia_segur\\libro.png"));

            //Assign the ImageList objects to the ListView.
            listViewLibros.LargeImageList = imageListLarge;
            listViewLibros.SmallImageList = imageListSmall;
        }

        private void listViewLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLibros.SelectedItems.Count > 0)
            {
                Libro l = listaLibros.ElementAt(listViewLibros.SelectedIndices[0]);
                LoadLibro(l);
            }
        }
        private void LoadLibro(Libro l)
        {
            titulo.Text = l.GetNombre();
            codigo.Text = l.GetCodigo();
            precio.Text = l.GetPrecio().ToString();
            autor.Text = l.autor;
            editorial.Text = l.editorial;
            isbn.Text = l.ISBN;
        }

        private void LoadLibroPrestado(Libro l)
        {
            tituloPrestado.Text = l.GetNombre();
            codigoPrestado.Text = l.GetCodigo();
            precioPrestado.Text = l.GetPrecio().ToString();
            fechaDevolucion.Text = l.GetFechaDevolucion().ToString();
            numRenovaciones.Text = l.GetNumRenovaciones().ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            titulo.Text = "";
            codigo.Text = "";
            precio.Text = "";
            autor.Text = "";
            editorial.Text = "";
            isbn.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listaLibros.Add(new Libro(codigo.Text, titulo.Text, Convert.ToDouble(precio.Text), isbn.Text, autor.Text, editorial.Text));
            }
            catch (Exception e1)
            {
                errores.Text = e1.Message;
            }
            finally
            {
                LoadListViewLibros();
            }
        }

        private void LoadListViewLibrosPrestados()
        {
            listViewLibrosPrestados.Clear();
            listViewLibrosPrestados.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            ListView.ListViewItemCollection listaLd =
                new ListView.ListViewItemCollection(listViewLibrosPrestados);

            foreach (Libro l in mochilaLibros)
            {
                listaLd.Add(l.ToString(), 0);
            }

            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile("E:\\copia_segur\\libro.png"));
            imageListLarge.Images.Add(Bitmap.FromFile("E:\\copia_segur\\libro.png"));

            //Assign the ImageList objects to the ListView.
            listViewLibros.LargeImageList = imageListLarge;
            listViewLibros.SmallImageList = imageListSmall;
        }
        private void bPrestar_Click(object sender, EventArgs e)
        {
            if (listViewLibros.SelectedItems.Count > 0)
            {
                Libro l = listaLibros.ElementAt(listViewLibros.SelectedIndices[0]);
                if (l.Prestar(mochilaLibros) == false)
                    errores.Text = "Ha ocurrido un error al prestar. Revisa tu prestamo.";
            }
            LoadListViewLibrosPrestados();
        }

        private void listViewLibrosPrestados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLibrosPrestados.SelectedItems.Count > 0)
            {
                Libro l = mochilaLibros.ElementAt(listViewLibrosPrestados.SelectedIndices[0]);
                LoadLibroPrestado(l);
            }
        }
    }
}
