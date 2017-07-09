using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace BD_Grupo3_VS
{
    public partial class AgregarPlanEjercicios : Form
    {
        Ejercicio ejercicio;
        string cedula;
        public AgregarPlanEjercicios(string cedulaNueva)
        {
            InitializeComponent();
            ejercicio = new Ejercicio();
            cedula = cedulaNueva;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {

        }

        #region Menu
        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
            this.Close();
        }

        private void crearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Close();
        }

        private void avanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Seguro que desea Salir ?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        /*             Hasta aqui las instrucciones de la cinta del menu  */
        #endregion

        private void AgregarPlanEjercicios_Load(object sender, EventArgs e)
        {
            TXT_Cedula.Text = cedula;
        }
    }
}
