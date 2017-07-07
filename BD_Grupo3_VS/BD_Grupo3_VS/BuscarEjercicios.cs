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
    public partial class BuscarEjercicios : Form
    {
        Ejercicio ejercicio;
        public BuscarEjercicios()
        {
            ejercicio = new Ejercicio();
            InitializeComponent();
        }

        private void ConsultarEjercicios_Load(object sender, EventArgs e)
        {
            llenarCombobox(CMB_FiltroNombre);
            llenarTabla(DGV_Ejercicios,null,null);
        }

        private void llenarTabla(DataGridView dataGridView, string filtroNombre, string filtroGeneral)
        {
            DataTable tabla = ejercicio.obtenerEjercicios(filtroNombre,filtroGeneral);
            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_Ejercicios.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if (CMB_FiltroNombre.Text == "" && TXT_Filtro.Text == "")
            {
                llenarTabla(DGV_Ejercicios, null, null);
            }
            else if (CMB_FiltroNombre.Text != "" && TXT_Filtro.Text == "")
            {
                llenarTabla(DGV_Ejercicios, CMB_FiltroNombre.Text, null);
            }
            else if (CMB_FiltroNombre.Text == "" && TXT_Filtro.Text != "")
            {
                llenarTabla(DGV_Ejercicios, null, TXT_Filtro.Text);
            }
            else if (CMB_FiltroNombre.Text != "" && TXT_Filtro.Text != "")
            {
                llenarTabla(DGV_Ejercicios, CMB_FiltroNombre.Text, TXT_Filtro.Text);
            }
        }

        private void llenarCombobox(ComboBox combobox)
        {
            SqlDataReader datos = ejercicio.obtenerListaNombresEjercicios();
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

        private void CMB_FiltroNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTabla(DGV_Ejercicios, CMB_FiltroNombre.Text, null);
        }
        

        private void BTN_Buscar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {

            if (DGV_Ejercicios.SelectedRows.Count == 0)
            {
                /*Mensaje no hay nada seleccionado*/
            }
            else
            {
                VerEjercicio ejercicio;
                string nombre = "";
                string descripcion = null;
                DataGridViewRow row = DGV_Ejercicios.CurrentRow;
                nombre = row.Cells[0].Value.ToString();
                descripcion = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "")
                {
                    ejercicio = new VerEjercicio(nombre, descripcion, false);
                }
                else
                {
                    ejercicio = new VerEjercicio(nombre, descripcion, true);
                }
                ejercicio.Show();
                this.Hide();
            }

        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
