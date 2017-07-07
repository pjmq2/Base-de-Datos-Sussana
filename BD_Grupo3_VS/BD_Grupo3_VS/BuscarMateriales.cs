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
    public partial class BuscarMateriales : Form
    {
        Material material;
        public BuscarMateriales()
        {
            InitializeComponent();
            material = new Material();
        }

        private void llenarTabla(DataGridView dataGridView, string filtroNombre)
        {
            DataTable tabla = material.consultarMateriales(filtroNombre);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;

            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for(int i = 0; i < DGV_Materiales.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        //Verificar parámetros
        private void llenarComboBox()
        {

        }

        private void ConsultarMateriales_Load(object sender, EventArgs e)
        {
            this.llenarTabla(DGV_Materiales, null);
            this.llenarComboBox();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.llenarTabla(DGV_Materiales, TXT_Filtro.Text);
        }

        private void BTN_VerModificar_Click(object sender, EventArgs e)
        {

        }

        /*  A partir de aqui empiezan los metodos para la cinta del menu    */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
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
            this.Hide();
        }

        private void crearTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Hide();
        }

        private void buscarTecnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnicas = new BuscarTecnicas();
            tecnicas.Show();
            this.Hide();
        }

        private void crearAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void crearMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Hide();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Hide();
        }

        private void crearEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Hide();
        }

        private void buscarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Hide();
        }
        /*  Hasta aqui las instrucciones de la cinta del menu   */
    }
}