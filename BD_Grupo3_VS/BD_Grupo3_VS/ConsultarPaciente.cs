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
    public partial class ConsultarPaciente : Form
    {
        Paciente paciente;
        public ConsultarPaciente()
        {
            InitializeComponent();
            paciente = new Paciente();
        }

        private void llenarTabla(DataGridView dataGridView, string filtroNombre, string filtroGeneral)
        {

            DataTable tabla = paciente.obtenerPacientes(filtroNombre, filtroGeneral);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_Pacientes.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if (TXT_FiltroNombre.Text == "" && TXT_FiltroGeneral.Text == "")
            {
                llenarTabla(DGV_Pacientes, null, null);
            }
            else if (TXT_FiltroNombre.Text != "" && TXT_FiltroGeneral.Text == "")
            {
                llenarTabla(DGV_Pacientes, TXT_FiltroNombre.Text, null);
            }
            else if (TXT_FiltroNombre.Text == "" && TXT_FiltroGeneral.Text != "")
            {
                llenarTabla(DGV_Pacientes, null, TXT_FiltroGeneral.Text);
            }
            else if (TXT_FiltroNombre.Text != "" && TXT_FiltroGeneral.Text != "")
            {
                llenarTabla(DGV_Pacientes, TXT_FiltroNombre.Text, TXT_FiltroGeneral.Text);
            }
        }

        private void ConsultarPaciente_Load(object sender, EventArgs e)
        {
            llenarTabla(DGV_Pacientes, null, null);
        }

        private void LINK_AgregarPaciente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarPaciente agregarP = new AgregarPaciente();
            agregarP.Show();
            this.Hide();

        }
    }
}
