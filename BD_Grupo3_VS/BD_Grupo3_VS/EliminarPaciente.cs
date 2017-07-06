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
    public partial class EliminarPaciente : Form
    {
        Paciente paciente;
        public EliminarPaciente()
        {
            InitializeComponent();
            paciente = new Paciente();
            
        }
        private void llenarTabla(DataGridView dataGridView)
        {
            
            DataTable tabla = paciente.obtenerPacientes(null, null);            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;

            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for (int i = 0; i < DGV_Pacientes.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void EliminarPaciente_Load(object sender, EventArgs e)
        {
            llenarTabla(DGV_Pacientes);
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            paciente.eliminarPaciente(TXT_Cedula.Text);                                          
            llenarTabla(DGV_Pacientes);
        }
    }
}
