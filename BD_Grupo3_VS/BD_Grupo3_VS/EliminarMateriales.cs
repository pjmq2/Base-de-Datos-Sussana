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
    public partial class EliminarMateriales : Form
    {
        Material material;
        public EliminarMateriales()
        {
            InitializeComponent();
            material = new Material();
        }
        private void llenarComboBox(ComboBox comboBox)
        {

        }

        private void llenarTabla(DataGridView dataGridView)
        {
            DataTable tabla = material.consultarMateriales(null);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;

            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for (int i = 0; i < dgv_materiales.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.llenarTabla(dgv_materiales);
        }

        private void lnk_agregarMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarMaterial agregar = new AgregarMaterial();
            agregar.Show();
            this.Hide();
        }

        private void EliminarMateriales_Load(object sender, EventArgs e)
        {
            llenarComboBox(cmb_nombre);
            llenarTabla(dgv_materiales);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            material.eliminarMaterial(cmb_nombre.Text);
            llenarComboBox(cmb_nombre);
            llenarTabla(dgv_materiales);
        }

        private void lnk_menuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
