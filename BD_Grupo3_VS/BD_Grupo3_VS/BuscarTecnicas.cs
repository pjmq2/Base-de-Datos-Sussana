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

        private void CB_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Nombre.Text != "Seleccione")
            {
                this.llenarTabla(DGV_Tecnicas, CB_Nombre.Text);
            }
        }

        private void BTN_VerModificar_Click(object sender, EventArgs e)
        {
            if (DGV_Tecnicas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la fila que desea modificar.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow row = DGV_Tecnicas.CurrentRow;
                string nombre = row.Cells[0].Value.ToString(); ;
                int precio = Convert.ToInt32(row.Cells[1].Value);

                VerTecnica tecnica = new VerTecnica(nombre, precio);
                tecnica.Show();
                this.Dispose();
            }
        }

        private void LNK_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Dispose();
        }

        /*  A partir de aqui empiezan los metodos para la cinta del menu */
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
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
                Environment.Exit(0);
            }
        }

        private void menuAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Dispose();
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

        private void buscarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
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

        private void BuscarTecnicas_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(0);
            } else
            {
                e.Cancel = true;
            }
        }
        /*  Hasta aqui las instrucciones de la cinta del menu   */
    }
}