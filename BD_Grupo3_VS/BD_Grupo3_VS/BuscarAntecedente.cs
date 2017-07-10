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
    public partial class BuscarAntecedentes : Form
    {
        Antecedentes antecedente;
        public BuscarAntecedentes()
        {            
            InitializeComponent();
            antecedente = new Antecedentes();
        }

        private void llenarTabla(DataGridView dataGridView, string nombre)
        {
            DataTable tabla = antecedente.obtenerAntecedentes(nombre);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_Antecedentes.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void llenarCombobox(ComboBox combobox)
        {
            SqlDataReader datos = antecedente.obtenerListaNombresAntecedentes();
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

        private void BuscarAntecedentes_Load(object sender, EventArgs e)
        {
            llenarTabla(DGV_Antecedentes, null);
            llenarCombobox(CB_Nombre);
        }

        #region Menu
        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void menuPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Dispose();
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Dispose();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Dispose();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Dispose();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Dispose();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Dispose();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Dispose();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Dispose();
        }
        /*             Hasta aqui las instrucciones de la cinta del menu  */
        #endregion

        private void CB_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTabla(DGV_Antecedentes, CB_Nombre.Text);
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if (CB_Nombre.Text == "")
            {
                llenarTabla(DGV_Antecedentes, null);
            }
            else 
            {
                llenarTabla(DGV_Antecedentes, CB_Nombre.Text);
            }            
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DGV_Antecedentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado ningún antecedente.", "Seleccionar Antecedente");
            }
            else
            {
                string nombre;
                DataGridViewRow row = DGV_Antecedentes.CurrentRow;
                nombre = row.Cells[0].Value.ToString();
                VerAntecedente va = new VerAntecedente(nombre);
                va.Show();
                this.Close();
            }
        }       
    }
}
