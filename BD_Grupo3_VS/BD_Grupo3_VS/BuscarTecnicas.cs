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
    public partial class BuscarTecnicas : Form
    {
        Tecnica tecnica;

        public BuscarTecnicas()
        {
            InitializeComponent();
            tecnica = new Tecnica();
        }

        private void llenarTabla(DataGridView dataGridView, string filtroNombre)
        {
            DataTable tabla = tecnica.consultarTecnicas(filtroNombre);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;

            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for (int i = 0; i < DGV_Tecnicas.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        //Verificar parámetros
        private void llenarComboBox()
        {
            SqlDataReader datos = tecnica.obtenerListaNombres();

            if(datos != null)
            {
                CB_Nombre.Items.Add("Seleccione");
                while (datos.Read())
                {
                    CB_Nombre.Items.Add(datos.GetValue(0));
                }
            }

        }

        private void BuscarTecnicas_Load(object sender, EventArgs e)
        {
            this.llenarTabla(DGV_Tecnicas, null);
            this.llenarComboBox();
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if (CB_Nombre.Text != null)
            {
                this.llenarTabla(DGV_Tecnicas, CB_Nombre.Text);
            }
        }

        private void BTN_VerModificar_Click(object sender, EventArgs e)
        {

        }

        /*  A partir de aqui empiezan los metodos para la cinta del menu */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicación", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Close();
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Close();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Close();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Close();
        }

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
            antecedente.Show();
            this.Close();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Close();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Close();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Close();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Close();
        }
        /*  Hasta aqui las instrucciones de la cinta del menu   */
    }
}