using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BD_Grupo3_VS
{
    public partial class AgregarEjercicio : Form
    {
        Ejercicio ejercicio;
        byte[] img;
        bool nombreModificado = false;

        public AgregarEjercicio()
        {
            ejercicio = new Ejercicio();
            InitializeComponent();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            nombreModificado = true;
        }

        private void btn_LoadAndSave_Click(object sender, EventArgs e)
        {
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
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Please Select a Image to save!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }
        
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!nombreModificado)
            {
                MessageBox.Show("Favor ponerle nombre al Ejercicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int result = ejercicio.agregarEjercicio(txt_nombre.Text, TXT_Descripcion.Text, img);
                if (pictureBox1.Image != null)
                {
                    ejercicio.insertarImagen(txt_nombre.Text, img);
                }
                if (result == 0)
                {
                    MessageBox.Show("¡El ejercicio ha sido agregada correctamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txt_nombre.Clear();
                    TXT_Descripcion.Clear();
                    if (pictureBox1.Image!=null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    img = null;
                }
                else
                {
                    if (result == 2627)
                    {
                        MessageBox.Show("Ya existe un ejercicio con ese nombre", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al intentar agregar el ejercicio \n \n error: " + result, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
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

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
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
            ConsultarAntecedentes antecedente = new ConsultarAntecedentes();
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
    }
}
