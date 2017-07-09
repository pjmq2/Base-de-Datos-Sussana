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
    public partial class VerPlanEjercicios : Form
    {
        PlanDeEjercicios planEjercicios;
        string cedula;
        string padActual;
        string nivel;
        public VerPlanEjercicios(string cedulaNueva, string padecimientoNuevo, string nivelNuevo)
        {
            cedula = cedulaNueva;
            padActual = padecimientoNuevo;
            nivel = nivelNuevo;
            InitializeComponent();
            planEjercicios = new PlanDeEjercicios();
        }

        private void llenarTabla(DataGridView dataGridView)
        {
            DataTable tabla = planEjercicios.obtenerTareas(cedula, padActual, nivel);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_Tareas.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void VerPlanEjercicios_Load(object sender, EventArgs e)
        {
            TXT_Cedula.Text = cedula;
            TXT_Padecimiento.Text = padActual;
            TXT_Nivel.Text = nivel;
            llenarTabla(DGV_Tareas);
        }

        private void BTN_AgregarTarea_Click(object sender, EventArgs e)
        {
            int result = planEjercicios.agregarTarea(cedula, padActual, nivel, TXT_Tarea.Text);
            if (result == 0)
            {
                MessageBox.Show("¡La tarea ha sido agregada al plan de ejercicio exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Tarea.Clear();
            }
            else
            {
                if (result == 2627)
                {
                    MessageBox.Show("¡Ya está la tarea asociada a este plan de ejercicios, en este nivel, de este padecimiento para el paciente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(result + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Se recargan las tareas
            llenarTabla(DGV_Tareas);
            TXT_Tarea.Clear();
        }
    }
}
