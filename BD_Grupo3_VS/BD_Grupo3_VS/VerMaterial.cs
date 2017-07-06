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
    public partial class VerMaterial : Form
    {
        Material materiales;
        string nombreMaterial;
        bool cambios = false;

        public VerMaterial(string nombreNuevo)
        {
            nombreMaterial = nombreNuevo;
            materiales = new Material();
            InitializeComponent();
        }

        private void ModificarMaterial_Load(object sender, EventArgs e)
        {
            TXT_Nombre.Text = nombreMaterial;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_EliminarMaterial_Click(object sender, EventArgs e)
        {
            materiales.eliminarMaterial(nombreMaterial);
        }

        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (cambios)
            {
                TXT_Nombre.BackColor = System.Drawing.Color.LightBlue;
            }
            cambios = true;
        }
    }
}
