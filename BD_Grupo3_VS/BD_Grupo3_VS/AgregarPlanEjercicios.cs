using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace BD_Grupo3_VS
{
    public partial class AgregarPlanEjercicios : Form
    {
        PlanDeEjercicios planEjercicio;
        string cedula;
        public AgregarPlanEjercicios(string cedulaNueva)
        {
            InitializeComponent();
            planEjercicio = new PlanDeEjercicios();
            cedula = cedulaNueva;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int resultado = planEjercicio.agregarPlanEjercicio(TXT_Cedula.Text, CB_Padecimiento.Text, TXT_Nivel.Text, TXT_Objetivos.Text);
            if (resultado == 0)
            {
                MessageBox.Show("¡El plan de ejercicio ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                TXT_Nivel.Clear();
                TXT_Objetivos.Clear();
                CB_Padecimiento.Refresh();
            }
            else
            {
                if (resultado == 2627)
                {
                    MessageBox.Show("¡Ya hay un plan de ejercicios de ese nivel para este padecimiento del paciento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void AgregarPlanEjercicios_Load(object sender, EventArgs e)
        {
            TXT_Cedula.Text = cedula;
            llenarCombobox(CB_Padecimiento);
        }

        //Se cargan al combobox los padecimiento actuales, es decir los planes de tratamiento
        private void llenarCombobox(ComboBox combobox)
        {
            SqlDataReader datos = planEjercicio.obtenerListaPadecimiento(cedula);
            if (datos != null)
            {
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                combobox.Items.Clear();
            }
            combobox.SelectedItem = 0;
        }

        private void BTN_BuscarPlan_Click(object sender, EventArgs e)
        {
            BuscarPlanEjercicios bpe = new BuscarPlanEjercicios(cedula);
            bpe.Show();
            this.Close();
        }
    }
}
