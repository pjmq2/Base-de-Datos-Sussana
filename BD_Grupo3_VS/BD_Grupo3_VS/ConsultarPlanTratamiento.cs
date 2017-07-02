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
    public partial class ConsultarPlanTratamiento : Form

    {

        PlanTratamiento planT;
        public ConsultarPlanTratamiento()
        {
            InitializeComponent();
            planT = new PlanTratamiento();
        }

        private void ConsultarPlanTratamiento_Load(object sender, EventArgs e)
        {

        }

        private void llenaTabla(DataGridView dgv, string porCedula, string porPadecimiento)
        {
            DataTable tabla = planT.consultarPlanTratamiento(porCedula, porPadecimiento);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = tabla;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgv.DataSource = bSource;

            for(int i = 0; i<dataGridView1.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 110;
            }
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if(TXT_Cedula.Text != "" && TXT_Padecimiento.Text == "")
            {
                llenaTabla(dataGridView1, TXT_Cedula.Text, null);
            }
            else if (TXT_Cedula.Text == "" && TXT_Padecimiento.Text != "")
            {
                llenaTabla(dataGridView1, null, TXT_Padecimiento.Text);
            }
            else if (TXT_Cedula.Text == "" && TXT_Padecimiento.Text == "")
            {
                llenaTabla(dataGridView1, null, null);
            }
            else if (TXT_Cedula.Text != "" && TXT_Padecimiento.Text != "")
            {
                llenaTabla(dataGridView1, TXT_Cedula.Text, TXT_Padecimiento.Text);
            }
        }

        private void LINK_AgregaPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarPlanTratamiento agrega = new AgregarPlanTratamiento();
            agrega.Show();
            this.Hide();
        }
    }
}
