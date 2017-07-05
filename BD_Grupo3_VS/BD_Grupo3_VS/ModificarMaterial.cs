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
    public partial class ModificarMaterial : Form
    {
        Material materiales;
        string nombreMaterial;

        public ModificarMaterial(string nombreNuevo)
        {
            nombreMaterial = nombreNuevo;
            materiales = new Material();
            InitializeComponent();
        }

        private void ModificarMaterial_Load(object sender, EventArgs e)
        {
            LBL_NombreEscogido.Text=nombreMaterial;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void BTN_EliminarMaterial_Click(object sender, EventArgs e)
        {
            materiales.eliminarMaterial(nombreMaterial);
        }
    }
}
