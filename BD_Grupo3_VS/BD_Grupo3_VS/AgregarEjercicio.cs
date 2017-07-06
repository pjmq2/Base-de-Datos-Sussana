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
        bool imagenCargada=false;
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
                imagenCargada = true;
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
                if (imagenCargada)
                {
                    var ms = new MemoryStream(img);
                    ejercicio.agregarEjercicio(txt_nombre.Text, TXT_Descripcion.Text, Image.FromStream(ms));
                }
                ejercicio.agregarEjercicio(txt_nombre.Text, TXT_Descripcion.Text, null);
            }
        }


        /*
               FUNCIONES PARA EL MENU 
        */

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPlanTratamiento plan = new AgregarPlanTratamiento();
            plan.Show();
            this.Hide();
        }

        private void agregarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void eliminarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPaciente paciente = new EliminarPaciente();
            paciente.Show();
            this.Hide();
        }
    }
}
