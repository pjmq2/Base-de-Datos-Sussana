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
    public partial class AgregarPaciente : Form
    {
        Paciente paciente;
        public AgregarPaciente()
        {
            InitializeComponent();
            paciente = new Paciente();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            //guardamos el genero escogido
            char genero = '	';

            if (RB_Femenino.Checked)
            {
                genero = 'F';
            }
            else if (RB_Masculino.Checked)
            {
                genero = 'M';
            }

            /*Añadimos un paciente con el método de agregarPaciente usando los paramétros insertados por el usuario*/
            int resultado = paciente.agregarPaciente(TXT_Cedula.Text, TXT_Nombre.Text, TXT_Apellido1.Text, TXT_Apellido2.Text,
                DTP_FechaNac.Value.ToString("yyyyMMdd"), genero, TXT_Valoracion.Text, TXT_Email.Text,  TXT_Telefono.Text, TXT_Comentarios.Text);

            //resultado es 0 cuando se pudo agregar paciente con éxito
            if (resultado == 0)
            {
                MessageBox.Show("¡El paciente ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Cedula.Clear();
                TXT_Nombre.Clear();
                TXT_Apellido1.Clear();
                TXT_Apellido2.Clear();
                TXT_Valoracion.Clear();
                TXT_Email.Clear();
                TXT_Telefono.Clear();
                TXT_Comentarios.Clear();
            }
            else
            {
                if (resultado == 2627)
                {
                    MessageBox.Show("Ya existe esa cédula asociada a otro paciente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar agregar el paciente. \n -Verifique que el número de cédula no corresponda " +
                        "a de algún paciente ya registrado en el sistema. \n -Recuerde que los campos de Cédula, Nombre, Primer apellido, Segundo apellido, " +
                        "fecha de nacimiento y valoración no pueden estar vacíos.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LINK_ListaPacientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuscarPaciente listaP = new BuscarPaciente();
            listaP.Show();
            this.Hide();
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
            BuscarPaciente paciente = new BuscarPaciente();
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
