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
    public partial class BuscarPlanEjercicios : Form
    {
        PlanDeEjercicios planEjercicio;
        string cedula;
        public BuscarPlanEjercicios(string cedulaNueva)
        {
            cedula = cedulaNueva;
            InitializeComponent();
            planEjercicio = new PlanDeEjercicios();
        }



        #region Menu
        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
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
        /*             Hasta aqui las instrucciones de la cinta del menu  */
        #endregion

        private void BuscarPlanEjercicios_Load(object sender, EventArgs e)
        {
            TXT_Cedula.Text = cedula;
            llenarTabla(DGV_PlanEjercicio);
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            llenarTabla(DGV_PlanEjercicio);
        }

        private void llenarTabla(DataGridView dataGridView)
        {
            DataTable tabla = planEjercicio.obtenerPlanEjercicios(cedula);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_PlanEjercicio.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DGV_PlanEjercicio.SelectedRows.Count == 0)
            { 
                MessageBox.Show("No ha seleccionado ningún plan de ejercicios.", "Seleccionar Antecedente");
            }
            else
            {
                DataGridViewRow row = DGV_PlanEjercicio.CurrentRow;
                string ced = row.Cells[0].Value.ToString();
                string padecimiento = row.Cells[1].Value.ToString();
                string nivel = row.Cells[2].Value.ToString();
                VerPlanEjercicios vpe = new VerPlanEjercicios(ced, padecimiento, nivel);
                vpe.Show();
                this.Close();
            }
        }
    }
}
