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
            if (CB_Nombre.Text == "" && TXT_FiltroGeneral.Text == "")
            {
                llenarTabla(DGV_Pacientes, null, null);
            }
            else if (CB_Nombre.Text != "" && TXT_FiltroGeneral.Text == "")
            {
                llenarTabla(DGV_Pacientes, CB_Nombre.Text, null);
            }
            else if (CB_Nombre.Text == "" && TXT_FiltroGeneral.Text != "")
            {
                llenarTabla(DGV_Pacientes, null, TXT_FiltroGeneral.Text);
            }
            else if (CB_Nombre.Text != "" && TXT_FiltroGeneral.Text != "")
            {
                llenarTabla(DGV_Pacientes, CB_Nombre.Text, TXT_FiltroGeneral.Text);
            }
        }

        private void ConsultarPaciente_Load(object sender, EventArgs e)
        {
            llenarTabla(DGV_Pacientes, null, null);
            llenarCombobox(CB_Nombre);
        }

        private void llenarCombobox(ComboBox combobox)
        {
            SqlDataReader datos = paciente.obtenerListaNombresPacientes();
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

        private void CB_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTabla(DGV_Pacientes,CB_Nombre.Text,null);
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DGV_Pacientes.SelectedRows.Count == 0)
            {
                /*Mensaje no hay nada seleccionado*/
            }
            else
            {
                string nombre;
                string apellido1;
                string apellido2;
                string cedula;
                DataGridViewRow row = DGV_Pacientes.CurrentRow;
                cedula = row.Cells[0].Value.ToString();
                nombre = row.Cells[1].Value.ToString();
                apellido1 = row.Cells[2].Value.ToString();
                apellido2 = row.Cells[3].Value.ToString();

                VerPaciente paciente = new VerPaciente(cedula, nombre, apellido1, apellido2);
                paciente.Show();
                this.Hide();
            }
            
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
        }/*             Hasta aqui las instrucciones de la cinta del menu  */

        
    }
}
