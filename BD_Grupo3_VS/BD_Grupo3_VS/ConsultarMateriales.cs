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
    public partial class ConsultarMateriales : Form
    {
        Material material;
        public ConsultarMateriales()
        {
            InitializeComponent();
            material = new Material();
        }

        private void lnk_menuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void lnk_eliminarMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarMateriales eliminar = new EliminarMateriales();
            eliminar.Show();
            this.Hide();
        }

        private void llenarTabla(DataGridView dataGridView, string filtroNombre)
        {
            DataTable tabla = material.consultarMateriales(filtroNombre);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;

            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for(int i = 0; i < dgv_materiales.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void ConsultarMateriales_Load(object sender, EventArgs e)
        {
            llenarTabla(dgv_materiales, null);
        }
    }
}
