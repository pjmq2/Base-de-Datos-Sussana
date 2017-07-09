using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        Ejercicio ejercicio;
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
            ejercicio = new Ejercicio();
        }


        private void llenarTablaTareas(DataGridView dataGridView)
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

        private void llenarTablaEjercicios(DataGridView dataGridView)
        {
            DataTable tabla = planEjercicios.obtenerEjerciciosDePlan(cedula, padActual, nivel);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_Tareas.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void llenarCombobox()
        {
            SqlDataReader datos = ejercicio.obtenerListaNombresEjercicios();
            if (datos != null)
            {
                while (datos.Read())
                {
                    CB_NombreEjercicio.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                CB_NombreEjercicio.Items.Clear();
            }
            CB_NombreEjercicio.SelectedItem = 0;
        }

        private void VerPlanEjercicios_Load(object sender, EventArgs e)
        {
            TXT_Cedula.Text = cedula;
            TXT_Padecimiento.Text = padActual;
            TXT_Nivel.Text = nivel;
            llenarTablaTareas(DGV_Tareas);
            llenarTablaEjercicios(DGV_ListaEjerciciosPlan);
            llenarCombobox();
        }

        private void BTN_AgregarTarea_Click(object sender, EventArgs e)
        {
            int result = planEjercicios.agregarTarea(cedula, padActual, nivel, TXT_Tarea.Text);
            if (result == 0)
            {
                MessageBox.Show("¡La tarea ha sido agregada al plan de ejercicio exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Tarea.Clear();
                //Se recargan las tareas
                llenarTablaTareas(DGV_Tareas);
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
        }

        private void BTN_AgregarEjercicio_Click(object sender, EventArgs e)
        {
            int result = planEjercicios.agregarEjercicioAPlan(cedula, padActual, nivel, CB_NombreEjercicio.Text, (int)NUD_Tiempo.Value, (int)NUD_Repeticiones.Value);
            if (result == 0)
            {
                MessageBox.Show("¡El ejercicio ha sido agregado al plan de ejercicios exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);

                llenarTablaEjercicios(DGV_ListaEjerciciosPlan);
                NUD_Repeticiones.ResetText();
                NUD_Tiempo.ResetText();
            }
            else
            {
                MessageBox.Show(result + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_EliminarPlan_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea elimar el plan de ejercicios de este paciente?", "Eliminar Plan de Ejercicios", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                int result = planEjercicios.eliminarPlanEjercicio(cedula, padActual, nivel);
                if (result == 0)
                {
                    MessageBox.Show("¡El plan de ejercicios ha sido eliminado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        #region Menu
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
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
        #endregion
       
    }
}
