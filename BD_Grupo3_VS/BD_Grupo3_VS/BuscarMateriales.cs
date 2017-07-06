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

        private void lnk_menuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
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

        private void ConsultarMateriales_Load(object sender, EventArgs e)
        {
            this.llenarTabla(DGV_Materiales, null);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.llenarTabla(DGV_Materiales, TXT_Filtro.Text);
        }
    }
}
