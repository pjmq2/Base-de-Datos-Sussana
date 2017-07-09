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

        public AgregarPlanTratamiento(string cedRecibida)
        {
            InitializeComponent();
            planT = new PlanTratamiento();
            TXT_Cedula.Text = cedRecibida;
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
                    MessageBox.Show("Ha ocurrido un error al intentar agregar el plan de tratamiento. Puede intentar lo siguiente:\n \n -Verifique que" +
                        " el número de cédula corresponda al de algún paciente registrado en el sistema \n -Verifique su conexión a la base de datos","Oops",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void AgregarPlanTratamiento_Load(object sender, EventArgs e)
        {

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

        private void BTN_VerPlanes_Click(object sender, EventArgs e)
        {
            ConsultarPlanTratamiento cp = new ConsultarPlanTratamiento(TXT_Cedula.Text);
            cp.Show();
            this.Dispose();
        }

        private void InicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Dispose();
        }

        private void buscarPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
            this.Dispose();
        }

        private void crearPacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Dispose();
        }

        private void avanzadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Dispose();
        }



        /*             Hasta aqui las instrucciones de la cinta del menu  */
    }
}
