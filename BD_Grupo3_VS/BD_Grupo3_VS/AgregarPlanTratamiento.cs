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
    }
}
