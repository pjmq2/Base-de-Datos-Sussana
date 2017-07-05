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
    public partial class AgregarMaterial : Form
    {

        Material material;

        public AgregarMaterial()
        {
            InitializeComponent();
            material = new Material();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int result = material.agregarMaterial(txt_nombre.Text, (int)nud_precio.Value);
            if(result == 0)
            {
                MessageBox.Show("El material ha sido agregado exitosamente",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                txt_nombre.Clear();
                nud_precio.Value = 0;
            } else if(result == 2627)
            {
                MessageBox.Show("Ya existe dicho material en el sistema.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lnk_menuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_agregarMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarMaterial agregarMaterial = new AgregarMaterial();
            agregarMaterial.Show();
            this.Hide();
        }

        private void lnk_menuPrincipal_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
