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
    public partial class AgregarPlanTratamiento : Form
    {
        PlanTratamiento planT;

        public AgregarPlanTratamiento()
        {
            InitializeComponent();
            planT = new PlanTratamiento();
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int result = planT.agregaPlanTratamiento(TXT_Cedula.Text, TXT_Padecimiento.Text, TXT_Observaciones.Text);
            if (result == 0)
            {
                MessageBox.Show("¡El plan de tratamiento ha sido agregado correctamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Cedula.Clear();
                TXT_Padecimiento.Clear();
                TXT_Observaciones.Clear();
            }
            else
            {
                if(result == 2627)
                {
                    MessageBox.Show("Ya existe este plan de tratamiento para este paciente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar agregar el plan de tratamiento. Puede intentar lo siguiente:\n \n \n -Verifique que" +
                        " el número de cédula corresponda al de algún paciente registrado en el sistema","Oops",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void AgregarPlanTratamiento_Load(object sender, EventArgs e)
        {

        }

        private void LINK_ListaTrata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarPlanTratamiento consulta = new ConsultarPlanTratamiento();
            consulta.Show();
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
