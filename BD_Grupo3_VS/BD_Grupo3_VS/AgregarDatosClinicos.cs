using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class AgregarDatosClinicos : Form
    {
        Paciente paciente;
        public AgregarDatosClinicos()
        {
            InitializeComponent();
            paciente = new Paciente();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int resultado = paciente.agregarDatoClinico(TXT_Cedula.Text, TXT_Dato.Text);

            //resultado es 0 cuando se pudo agregar un dato clínico al paciente con éxito
            if (resultado == 0)
            {
                MessageBox.Show("¡El dato clínico ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Cedula.Clear();
                TXT_Dato.Clear();
            }
            else
                if (resultado == 2627)
            {
                MessageBox.Show("Ya existe este dato clínico asociado a este paciente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Algo ha salido mal.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPaciente paciente = new ConsultarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void crearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void avanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Seguro que desea Salir ?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                //Aun no cierra todo el programa
            }
        }

        /*             Hasta aqui las instrucciones de la cinta del menu  */
    }
}
