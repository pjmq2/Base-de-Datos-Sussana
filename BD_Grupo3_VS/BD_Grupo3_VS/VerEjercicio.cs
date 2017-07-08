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
        bool cambioImagen = false;
        bool cambioNombre = false;
        bool cambioDescripcion = false;

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
            if (PB_Imagen.Image != null)
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
                cambioImagen = true;
            }
            else
            {
                MessageBox.Show("Please Select a Image to save!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }

        private void BTN_EliminarMaterial_Click(object sender, EventArgs e)
        {
            int result = ejercicio.eliminarejercicio(nombre);
            MessageBox.Show("¡El ejercicio ha sido eliminado exitosamente! ", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            bool cambioHecho = false;

            if (cambioImagen)
            {
                ejercicio.insertarImagen(nombre,img);
            }
            int result = ejercicio.modificarDescripcion(nombre, TXT_Descripcion.Text);
            if (result !=0)
            {
                MessageBox.Show("Ha ocurrido un error guardando los cambios", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                if (!nombre.Equals(TXT_Nombre.Text))
                {
                    result = ejercicio.modificarNombre(nombre, TXT_Nombre.Text);
                    if (result == 0)
                    {
                        cambioHecho = true;
                    }
                    else
                    {
                        if (result == 2627)
                        {
                            MessageBox.Show("Ya existe un ejercicio con ese nombre, favor seleccionar otro nombre", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            MessageBox.Show("Ha ocurrido un error al intentar modificar el ejercicio "+result, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    cambioHecho = true;
                }
            }
            if (cambioHecho)
            {
                MessageBox.Show("¡El ejercicio ha sido modificado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                MenuConfig menu = new MenuConfig();
                menu.Show();
                this.Hide();
            }
        }

        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambioNombre)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }
            cambioNombre = true;
        }

        private void TXT_Descripcion_TextChanged(object sender, EventArgs e)
        {
            if (cambioDescripcion)
            {
                TXT_Descripcion.BackColor = System.Drawing.Color.LightBlue;
            }
            cambioDescripcion = true;
        }

        #region Menu
        /* A partir de aqui empiezan los metodos para la cinta del menu  */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Hide();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Hide();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Hide();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Hide();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Hide();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Hide();
        }
        /*  Hasta aqui las instrucciones de la cinta del menu   */
    #endregion 

    }
}
