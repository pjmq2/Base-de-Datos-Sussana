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
        public AgregarEjercicio()
        {
            InitializeComponent();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LoadAndSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog fop = new OpenFileDialog(); //create object of open file dialog
            fop.InitialDirectory = @"C:\"; //set Initial directory
            fop.Filter = "[JPG,JPEG]|*.jpg"; //set filter for select only .jpg files
            if (fop.ShowDialog() == DialogResult.OK) //display open file dialog to user and only user select a image enter to if block
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read); //create a file stream object associate to user selected file 
                byte[] img = new byte[FS.Length]; //create a byte array with size of user select file stream length
                FS.Read(img, 0, Convert.ToInt32(FS.Length));//read user selected file stream in to byte array       
                /*
                 * Aqui va la parte de enlazarlo con SQL
                 */
                MessageBox.Show("Image Save Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display save successful message to user
            }
            else
            {
                MessageBox.Show("Please Select a Image to save!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPlanTratamiento plan = new AgregarPlanTratamiento();
            plan.Show();
            this.Hide();
        }
    }
}
