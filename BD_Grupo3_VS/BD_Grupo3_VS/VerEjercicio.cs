using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class VerEjercicio : Form
    {
        Ejercicio ejercicio;
        string nombre;
        string descripcion;
        Image imagen;
        byte[] img;

        public VerEjercicio(string nombreNuevo, string descripcionNuevo, bool hayImagen)
        {
            InitializeComponent();
            ejercicio = new Ejercicio();
            nombre = nombreNuevo;
            descripcion = descripcionNuevo;
            TXT_Nombre.Text = nombre;
            TXT_Descripcion.Text = descripcion;
            if (hayImagen)
            {
                imagen = ejercicio.obtenerImagen(nombre);
                PB_Imagen.Image = imagen;
                PB_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_LoadAndSave_Click(object sender, EventArgs e)
        {
            if (PB_Imagen != null)
            {
                PB_Imagen.Image.Dispose();
            }

            OpenFileDialog fop = new OpenFileDialog(); //create object of open file dialog
            fop.InitialDirectory = @"C:\"; //set Initial directory
            fop.Filter = "[JPG,JPEG]|*.jpg"; //set filter for select only .jpg files
            if (fop.ShowDialog() == DialogResult.OK) //display open file dialog to user and only user select a image enter to if block
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read); //create a file stream object associate to user selected file 
                img = new byte[FS.Length]; //create a byte array with size of user select file stream length
                FS.Read(img, 0, Convert.ToInt32(FS.Length));//read user selected file stream in to byte array       

                MessageBox.Show("Image Save Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
                var ms = new MemoryStream(img);
                PB_Imagen.Image = Image.FromStream(ms);
                PB_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Please Select a Image to save!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }

        private void BTN_EliminarMaterial_Click(object sender, EventArgs e)
        {
            int result = ejercicio.eliminarejercicio(nombre);
            MessageBox.Show("¡El ejercicio ha sido agregado exitosamente! " + result, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
        }
    }
}
