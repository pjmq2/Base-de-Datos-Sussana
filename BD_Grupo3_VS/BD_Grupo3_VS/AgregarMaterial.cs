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
    }
}
